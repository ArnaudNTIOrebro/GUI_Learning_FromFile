using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using IronXL;

namespace GUI_Learning
{
    public partial class Form1 : Form
    {
        Excel.Application ExcelObj = null;
        Excel.Workbooks wbooks = null;
        Excel.Workbook workbook = null;
        Excel.Worksheet worksheet = null;       
        Excel.Sheets sheets = null;             
        public static string strFilePath = "";
        public static string strFileName = "";
        public Form1()
        {
            InitializeComponent();
            ExcelObj = new Excel.Application();
            strFilePath = "Subjects1.xlsx";           
            wbooks = ExcelObj.Workbooks;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> dataFromCSV =  GetDataFromCSVFile();
            Populate_CbxData_WithList(dataFromCSV, cbxCSV); // namnet på "cbxCSV" är annorlunda för dig.

            List<string> subjectsFromExcel = GetExcelData_Directly();
            Populate_CbxData_WithList(subjectsFromExcel, cbxSubjectsExcel);// namnet på "cbxSubjectsExcel" är annorlunda för dig.             
        }

        private List<string> GetDataFromCSVFile()
        {
            List<string>  subjectsFromCSV = new List<string>();

            try   //här kan du byta namnet "subjects" i parameter med namnet "subjects2" för att generera fel i undantag.
            {                
                var CSVData = File.ReadAllLines("subjects.csv");

                foreach (var data in CSVData)
                {
                    var strSubject = data.Split(',');
                    subjectsFromCSV.Add(strSubject[2]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Problem with CSV : " + e.ToString());
            }
            
            return subjectsFromCSV;
        }

        private List<string> GetExcelData_Directly()
        {
            List<string> subjectsFromExcel = new List<string>();
            string cellContent = String.Empty;
            int currentSheet = 1;
            string strFilePath2 = String.Empty;

            try       //här kan du byta namnet "strFilePath" i parameter med namnet "strFilePath2" för att generera fel i undantag.
            {
                workbook = wbooks.Open(strFilePath, 0, false, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, true, true);
                sheets = workbook.Worksheets;

                worksheet = (Excel.Worksheet)sheets.get_Item(currentSheet);

                for (int i = 2; i < 20; i++)
                {
                    cellContent = worksheet.Cells[i, 1].Value;

                    if (!String.IsNullOrEmpty(cellContent))
                    {
                        subjectsFromExcel.Add(cellContent);
                    }
                }
            }
            catch(Exception e) 
            {
                MessageBox.Show("Problem med Excel dok: " + e.ToString());
            }
            finally
            {
                releaseObject(worksheet);
                releaseObject(sheets);
                releaseObject(workbook);
                releaseObject(wbooks);
                releaseObject(ExcelObj);                
            }
            return subjectsFromExcel;
        }

        private void Populate_CbxData_WithList(List<string> subjects, ComboBox combobox )
        {
            List<string> Local_Subjects = subjects;

            for (int i = 0; i < Local_Subjects.Count; i++)
            {
                combobox.Items.Add(Local_Subjects[i]);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }       
    }

}
    

