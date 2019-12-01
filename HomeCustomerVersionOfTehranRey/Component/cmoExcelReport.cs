using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace ExcelReport
{
    public partial class cmoExcelReport : Component
    {
        int StartRowIndex = 0;
        int RowsInPage = 26;
        int counter = 0;
        string destenation;


        Microsoft.Office.Interop.Excel.Application m_objExcel;
        Microsoft.Office.Interop.Excel.Workbooks m_objBooks;
        Microsoft.Office.Interop.Excel._Workbook m_objBook;

        object m_objOpt = System.Reflection.Missing.Value;

        Microsoft.Office.Interop.Excel.Sheets m_objSheets;
        Microsoft.Office.Interop.Excel._Worksheet m_objSheet;
        Microsoft.Office.Interop.Excel.Range m_objRange;
        Font m_objFont;

        public cmoExcelReport()
        {
            InitializeComponent();
        }

        public string prop_CustomerName { get; set; }
        public long prop_CustomerID { get; set; }
        public string prop_PhoneNumber { get; set; }
        public string prop_Address { get; set; }
        public DateTime prop_date { get; set; }
        public long prop_FactorID { get; set; }

        public void start2(DataGridView dgv, List<DataGridViewColumn> columnsShouldSum)
        {
            this.FillArray(dgv, columnsShouldSum);
            //m_objExcel.Visible = true;
            this.SetCustomerInformation(dgv);
            this.FormatCustomerInfoCells(dgv);
            this.Header_Footer();
            this.FormatAllCells(dgv);
            this.FormatHeaderRow();
            this.FormatTotalRow(dgv);
            this.FormatEachPage(dgv);
            this.FormatOddRows(dgv);
            m_objExcel.Visible = true;
            m_objSheet.PrintPreview(m_objOpt);
        }

        private void FillArray(DataGridView dgv, List<DataGridViewColumn> columnsShuldSum)
        {
            this.destenation = ((char)(((byte)('A')) + dgv.Columns.Count - 1)).ToString();
           
            // Start a new workbook in Excel.
            m_objExcel = new Microsoft.Office.Interop.Excel.Application();
            
            m_objBooks = (Microsoft.Office.Interop.Excel.Workbooks)m_objExcel.Workbooks;
            m_objBook = (Microsoft.Office.Interop.Excel._Workbook)(m_objBooks.Add(m_objOpt));
            m_objSheets = (Microsoft.Office.Interop.Excel.Sheets)m_objBook.Worksheets;
            m_objSheet = (Microsoft.Office.Interop.Excel._Worksheet)(m_objSheets.get_Item(1));

            // ************************************ Set LandScape & Size ********************************

            m_objSheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            m_objSheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            m_objSheet.DisplayRightToLeft = true;

            // ************************************ End of Set LandScape & Size ********************************

            //  ************************************ Fill Data in cells ********************************
            // Create an array for the headers and add it to cells A1:C1.
            //object[] objHeaders = { "Order ID", "Amount", "Tax" };

            List<string> Headers = new List<string>();
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                Headers.Add(dgv.Columns[i].HeaderText);
            }

            m_objRange = m_objSheet.get_Range("A" + (1 + StartRowIndex).ToString(), this.destenation + (1 + StartRowIndex).ToString());
            m_objRange.Value2 = Headers.ToArray();
            m_objFont = m_objRange.Font;
            m_objFont.Bold = true;

            // Create an array with 3 columns and 100 rows and add it to
            // the worksheet starting at cell A2.

            object[,] objData = new Object[dgv.RowCount, dgv.ColumnCount];
            //Random rdm = new Random((int)DateTime.Now.Ticks);
            //double nOrderAmt, nTax;
            for (int r = 0; r < dgv.RowCount; r++)
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    objData[r, i] = dgv[i, r].Value.ToString();
                }
            }
            m_objRange = m_objSheet.get_Range("A" + (2 + StartRowIndex).ToString(), m_objOpt);
            m_objRange = m_objRange.get_Resize(dgv.RowCount, dgv.ColumnCount);
            m_objRange.Value2 = objData;

            // Insert Customer Info ...



            //  ************************************ End of Fill Data in cells ********************************

            //  ************************************ Sum Columns Should Sum ********************************
            for (int i = 0; i < columnsShuldSum.Count; i++)
			{
                int index = columnsShuldSum[i].Index;
                string Cellposition = (((((char)(((byte)('A')) + index)))).ToString()) + ((dgv.RowCount + (3 + StartRowIndex)).ToString());
                m_objRange = m_objSheet.get_Range(Cellposition, m_objOpt);
                
                m_objRange.Select();

                m_objRange.Borders[XlBordersIndex.xlEdgeLeft].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight =
                    Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_objRange.Borders[XlBordersIndex.xlEdgeTop].LineStyle =
                    Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_objRange.Borders[XlBordersIndex.xlEdgeTop].Weight =
                    Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_objRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle =
                    Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_objRange.Borders[XlBordersIndex.xlEdgeBottom].Weight =
                    Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
                m_objRange.Borders[XlBordersIndex.xlEdgeRight].LineStyle =
                    Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_objRange.Borders[XlBordersIndex.xlEdgeRight].Weight =
                    Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;

                string formula = "=SUM(R[-" + (dgv.RowCount+1).ToString() + "]C:R[-2]C)";
                m_objRange.FormulaR1C1 = formula;


                if (i%2 != 0)
	            { 
            		m_objRange = m_objSheet.get_Range(((((char)(((byte)('A')) + index)))).ToString() + "1" , 
                        ((((char)(((byte)('A')) + index-1)))).ToString() + (dgv.RowCount + 4) .ToString());
                    m_objRange.NumberFormat = "#,##0";

	            }
                if (i == columnsShuldSum.Count-1)
                {
                    m_objRange = m_objSheet.get_Range(((((char)(((byte)('A')) + index)))).ToString() + "1",
                        ((((char)(((byte)('A')) + index - 1)))).ToString() + (dgv.RowCount + 4).ToString());
                    m_objRange.NumberFormat = "#,##0";

                }
			}

        }

        private void SetCustomerInformation(DataGridView dgv)
        {
            string des_EndMinuss = ((char)(((byte)('A')) + dgv.Columns.Count - 2)).ToString();
            string des_End = ((char)(((byte)('A')) + dgv.Columns.Count - 1)).ToString();
            string des_EndMinussPlus = ((char)(((byte)('A')) + dgv.Columns.Count - 3)).ToString();
            string des_EndMinussPlusPlus = ((char)(((byte)('A')) + dgv.Columns.Count - 4)).ToString();

            m_objRange = m_objSheet.get_Range("A1", m_objOpt);
            m_objRange.EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown,
                m_objOpt);
            m_objRange.EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown,
                m_objOpt);
            m_objRange.EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown,
                m_objOpt);
            m_objRange.EntireRow.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown,
                m_objOpt);

            m_objRange = m_objSheet.get_Range("A1", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = " صورتحساب : ";
            m_objRange = m_objSheet.get_Range("B1", des_EndMinussPlusPlus + "1");
            m_objRange.Select();
            m_objRange.MergeCells = true;
            m_objRange.FormulaR1C1 = this.prop_CustomerName;

            m_objRange = m_objSheet.get_Range("A2", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = " کد اشتراک:";
            m_objRange = m_objSheet.get_Range("B2", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = this.prop_CustomerID;

            m_objRange = m_objSheet.get_Range(des_EndMinuss + "1", des_EndMinussPlus + "1");
            m_objRange.Select();
            m_objRange.MergeCells = true;
            m_objRange.FormulaR1C1 = "شماره فاکتور:";
            m_objRange.Select();
            m_objRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            m_objRange = m_objSheet.get_Range(des_End + "1", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = this.prop_FactorID;

            FarsiLibrary.Utils.PersianDate dt;
            dt = (FarsiLibrary.Utils.PersianDateConverter.ToPersianDate(this.prop_date));
            m_objRange = m_objSheet.get_Range(des_EndMinuss + "2", des_EndMinussPlus + "2");
            m_objRange.Select();
            m_objRange.MergeCells = true;
            m_objRange.FormulaR1C1 = "تاریخ صدور:";
            m_objRange.Select();
            m_objRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
            m_objRange = m_objSheet.get_Range(des_End + "2", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = dt;

            m_objRange = m_objSheet.get_Range(des_EndMinuss + "3", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = "تلفن:";
            m_objRange = m_objSheet.get_Range(des_End + "3", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = this.prop_PhoneNumber;

            m_objRange = m_objSheet.get_Range("A3", m_objOpt);
            m_objRange.Select();
            m_objRange.FormulaR1C1 = " آدرس:";
            m_objRange = m_objSheet.get_Range("B3", des_EndMinussPlusPlus +"3");
            m_objRange.Select();
            m_objRange.MergeCells = true;
            m_objRange.FormulaR1C1 = this.prop_Address;
        }

        private void Header_Footer()
        {
            //m_objSheet.PageSetup.CenterHeaderPicture.Filename = @"C:\Users\Majid\Desktop\majid\فاکتور\Arm.jpg";
            //m_objSheet.PageSetup.CenterHeaderPicture.Height = (float)80;
            //m_objSheet.PageSetup.CenterHeaderPicture.Width = (float)144.75;

            //m_objSheet.PageSetup.RightFooterPicture.Filename = @"C:\Users\Majid\Desktop\majid\فاکتور\Address.jpg";
            //m_objSheet.PageSetup.RightFooterPicture.Height = (float)30.75;
            //m_objSheet.PageSetup.RightFooterPicture.Width = (float)297;

            m_objSheet.PageSetup.LeftHeader ="";
//            m_objSheet.PageSetup.CenterHeader ="&G";
            m_objSheet.PageSetup.CenterHeader = "";
            m_objSheet.PageSetup.RightHeader = "";

            m_objSheet.PageSetup.LeftFooter ="";
            m_objSheet.PageSetup.CenterFooter ="";
//            m_objSheet.PageSetup.RightFooter = "&G";
            m_objSheet.PageSetup.RightFooter = "";
            m_objSheet.PageSetup.LeftMargin = m_objExcel.InchesToPoints(0.7);
            m_objSheet.PageSetup.RightMargin = m_objExcel.InchesToPoints(0.7);
            m_objSheet.PageSetup.TopMargin = m_objExcel.InchesToPoints(1.2);
            m_objSheet.PageSetup.BottomMargin = m_objExcel.InchesToPoints(0.80);
            m_objSheet.PageSetup.HeaderMargin = m_objExcel.InchesToPoints(0);
            m_objSheet.PageSetup.FooterMargin = m_objExcel.InchesToPoints(0.1);
            m_objSheet.PageSetup.Zoom = 100;
            m_objSheet.PageSetup.PrintErrors = Microsoft.Office.Interop.Excel.XlPrintErrors.xlPrintErrorsDisplayed;
        }

        private void FormatAllCells(DataGridView dgv)
        {
            //****************************** Set the border of table value *********************
            m_objRange = m_objSheet.get_Range("A5",
                this.destenation + (dgv.RowCount + 1 + this.counter + 4).ToString());
            m_objRange.Select();

            //********** Set the Font of Rows *********************
            {
                m_objRange.Font.Name = "B Mitra";
                m_objRange.Font.Size = 11;
                m_objRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
            }
            //End Of //********** Set the Font of Rows *********************

            m_objRange.Borders[XlBordersIndex.xlDiagonalDown].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
            m_objRange.Borders[XlBordersIndex.xlDiagonalUp].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;

            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeTop].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeTop].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeBottom].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeRight].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeRight].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;

            m_objRange.Borders[XlBordersIndex.xlInsideHorizontal].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlInsideHorizontal].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline;
            m_objRange.Borders[XlBordersIndex.xlInsideVertical].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlInsideVertical].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlHairline;


            //End Of //****************************** Set the border of table value *********************
        }

        private void FormatHeaderRow()
        {
            //****************************** Set the border of Header ****************************
            m_objRange = m_objSheet.get_Range("A5", this.destenation + "5");
            m_objRange.Select();

            m_objRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;

            m_objRange.Borders[XlBordersIndex.xlDiagonalDown].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
            m_objRange.Borders[XlBordersIndex.xlDiagonalUp].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;

            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeTop].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeTop].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeBottom].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeRight].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeRight].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;

            m_objRange.Borders[XlBordersIndex.xlInsideVertical].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlInsideVertical].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;

            m_objRange.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
            m_objRange.Interior.PatternColorIndex = Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic;
            m_objRange.Interior.Color = 16763955;
            //End Of //****************************** Set the border of Header ****************************
        }

        private void FormatTotalRow(DataGridView dgv)
        {
            //****************************** Set the border of Total Row *********************
            m_objRange = m_objSheet.get_Range("A" + (dgv.RowCount + (3 + 4)).ToString()
                , this.destenation + (dgv.RowCount + (3 + 4)).ToString());
            m_objRange.Select();

            m_objRange.Borders[XlBordersIndex.xlDiagonalDown].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
            m_objRange.Borders[XlBordersIndex.xlDiagonalUp].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;

            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeTop].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeTop].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeBottom].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            m_objRange.Borders[XlBordersIndex.xlEdgeRight].LineStyle =
                Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            m_objRange.Borders[XlBordersIndex.xlEdgeRight].Weight =
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;

            m_objRange.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternSolid;
            m_objRange.Interior.PatternColorIndex = Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic;
            m_objRange.Interior.Color = 3407769;
            m_objRange.Font.Name = "B Mitra";
            m_objRange.Font.Size = 12;
            m_objRange.Font.Bold = true;

            m_objRange = m_objSheet.get_Range("A" + (dgv.RowCount + (3 + 4)).ToString(), m_objOpt);
            m_objRange.Select();
            m_objRange.Value2 = "مجموع";
            //End Of//****************************** Set the border of Total Row *********************
        }

        private void FormatEachPage(DataGridView dgv)
        {

            //****************************** Set the Border Of Each Page *********************
            int start = this.RowsInPage + 1;

            for (start = this.RowsInPage + 1; start < dgv.RowCount + 4 + counter ; start += this.RowsInPage)
            {
                // *********** Copy Header In Each Page ***************
                m_objRange = m_objSheet.get_Range("A5"  , this.destenation + "5");
                m_objRange.Select();
                m_objRange.Copy(m_objOpt);

                m_objRange = m_objSheet.get_Range("A" + start.ToString(), this.destenation + start.ToString());
                m_objRange.Select();
                m_objRange.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, m_objOpt);

                this.counter++;
                //End Of // *********** Copy Header In Each Page ***************
            }
            //End of //****************************** Set the Border Of Each Page *********************

            // *********** bottom order of Each Page ***************
            for (int i = this.RowsInPage; i < dgv.RowCount + 4 + this.counter + 2; i += this.RowsInPage)
            {
                m_objRange = m_objSheet.get_Range("A" + i.ToString(),
                    this.destenation + i.ToString());
                m_objRange.Select();
                m_objRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle =
                       Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                m_objRange.Borders[XlBordersIndex.xlEdgeBottom].Weight =
                    Microsoft.Office.Interop.Excel.XlBorderWeight.xlMedium;
            }

            //End Of // *********** bottom order of Each Page **************

        }

        private void FormatOddRows(DataGridView dgv)
        {
            //****************************** Set the Color of Odd Rows ***************************
            for (int i = 6 + StartRowIndex; i < dgv.RowCount + (4 + 2) + counter; i++)
            {
                if (i % 2 != 0 && i % this.RowsInPage != 1)
                {
                    m_objRange = m_objSheet.get_Range("A" + i.ToString(), this.destenation + i.ToString());
                    m_objRange.Select();
                    m_objRange.Interior.Color = 13421823;
                }
            }
            //****************************** End of Set the Color of Odd Rows *********************
        }

        private void FormatCustomerInfoCells(DataGridView dgv)
        {
            string des_EndMinuss = ((char)(((byte)('A')) + dgv.Columns.Count - 2)).ToString();
            string des_End = ((char)(((byte)('A')) + dgv.Columns.Count - 1)).ToString();
            string des_EndMinussPlus = ((char)(((byte)('A')) + dgv.Columns.Count - 3)).ToString();
            string des_EndMinussPlusPlus = ((char)(((byte)('A')) + dgv.Columns.Count - 4)).ToString();

            m_objRange = m_objSheet.get_Range("A1" , destenation + "3");
            m_objRange.Select();
            m_objRange.Font.Name = "B Mitra";
            m_objRange.Font.FontStyle = "Bold";
            m_objRange.Font.Size = 11;
            m_objRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight;

            m_objRange.Interior.Pattern = Microsoft.Office.Interop.Excel.XlPattern.xlPatternGray8;
            m_objRange.Interior.PatternColorIndex = Microsoft.Office.Interop.Excel.XlColorIndex.xlColorIndexAutomatic;

            m_objRange.Borders[XlBordersIndex.xlDiagonalDown].LineStyle  = 
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;
            m_objRange.Borders[XlBordersIndex.xlDiagonalUp].LineStyle  = 
                Microsoft.Office.Interop.Excel.XlLineStyle.xlLineStyleNone;

            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].LineStyle  = 
                Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble;
            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight  = 
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;
            m_objRange.Borders[XlBordersIndex.xlEdgeRight].LineStyle  = 
                Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble;
            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight = 
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;
            m_objRange.Borders[XlBordersIndex.xlEdgeTop].LineStyle  = 
                Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble;
            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight= 
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;
            m_objRange.Borders[XlBordersIndex.xlEdgeBottom].LineStyle  = 
                Microsoft.Office.Interop.Excel.XlLineStyle.xlDouble;
            m_objRange.Borders[XlBordersIndex.xlEdgeLeft].Weight  = 
                Microsoft.Office.Interop.Excel.XlBorderWeight.xlThick;

            m_objRange = m_objSheet.get_Range(des_EndMinuss + "1", des_EndMinussPlus + "1");
            m_objRange.Select();
            m_objRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;

            m_objRange = m_objSheet.get_Range(des_EndMinuss + "2", des_EndMinussPlus + "2");
            m_objRange.Select();
            m_objRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft;
        }

        private string Chr(int p)
        {
            throw new NotImplementedException();
        }

        public cmoExcelReport(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
