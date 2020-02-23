using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApplication34.Data;

namespace WebApplication34.Helper
{
    public class ExcelComunication
    {
        public static DataTable ExcelToDataTable(string filename)
        {
            DataTable dt = new DataTable();
            using (SpreadsheetDocument spreadSheetDocument = SpreadsheetDocument.Open(filename, false))
            {

                WorkbookPart workbookPart = spreadSheetDocument.WorkbookPart;
                IEnumerable<Sheet> sheets = spreadSheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();
                string relationshipId = sheets.First().Id.Value;
                WorksheetPart worksheetPart = (WorksheetPart)spreadSheetDocument.WorkbookPart.GetPartById(relationshipId);
                Worksheet workSheet = worksheetPart.Worksheet;
                SheetData sheetData = workSheet.GetFirstChild<SheetData>();
                IEnumerable<Row> rows = sheetData.Descendants<Row>();

                foreach (Cell cell in rows.ElementAt(0))
                {
                    dt.Columns.Add(GetCellValue(spreadSheetDocument, cell));
                }

                foreach (Row row in rows) //this will also include your header row...
                {
                    DataRow tempRow = dt.NewRow();

                    for (int i = 0; i < row.Descendants<Cell>().Count(); i++)
                    {
                        try
                        {
                            tempRow[i] = GetCellValue(spreadSheetDocument, row.Descendants<Cell>().ElementAt(i));
                        }
                        catch (Exception)
                        {

                            tempRow[i] = "";
                        }

                    }

                    dt.Rows.Add(tempRow);
                }
                dt.Rows.RemoveAt(0); //...s
            }
            return dt;
        }
        public static string GetCellValue(SpreadsheetDocument document, Cell cell)
        {
            SharedStringTablePart stringTablePart = document.WorkbookPart.SharedStringTablePart;
            string value = cell.CellValue.InnerXml;

            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {


                return stringTablePart.SharedStringTable.ChildElements[Int32.Parse(value)].InnerText;


            }
            else
            {
                return value;
            }
        }
        public static List<OriginalListing> DataTableTooriginal_listing(DataTable data, int year, int batch)
        {
            List<OriginalListing> datas = new List<OriginalListing>();
            foreach (DataRow item in data.Rows)
            {
                //var dd =  item[0-1];
                try
                {
                    var tmp = new OriginalListing
                    {
                        FullName = item[1 - 1].ToString().Trim(),
                        CmndNumber= item[2 - 1].ToString().Trim(),
                        CmndIssueDay = item[3 - 1].ToString().Trim(),
                        Address = item[4 - 1].ToString().Trim(),
                        Country = item[5 - 1].ToString().Trim(),
                        NumberStockNotDeposite = decimal.Parse(item[6 - 1].ToString().Trim()),
                        NumberStockDeposited = decimal.Parse(item[7 - 1].ToString().Trim()),
                        NumberStockTotal = decimal.Parse(item[8 - 1].ToString().Trim()),
                        DividendNotDeposite= decimal.Parse(item[9 - 1].ToString().Trim()),
                        DividendDeposited = decimal.Parse(item[10 - 1].ToString().Trim()),
                        DividendTotal = decimal.Parse(item[11 - 1].ToString().Trim()),
                        TaxNotDeposite = decimal.Parse(item[12 - 1].ToString().Trim()),
                        TaxDeposited = decimal.Parse(item[13 - 1].ToString().Trim()),
                        TaxTotal = decimal.Parse(item[14 - 1].ToString().Trim()),
                        DividendReceivedNotDeposite = decimal.Parse(item[15 - 1].ToString().Trim()),
                        DividendReceivedDeposited = decimal.Parse(item[16 - 1].ToString().Trim()),
                        DividendReceivedTotal = decimal.Parse(item[17 - 1].ToString().Trim()),
                        Type = item[18 - 1].ToString().Trim(),
                        AssignmentOrganization = item[19 - 1].ToString().Trim(),
                        Txnum = item[20 - 1].ToString().Trim(),
                        Email = item[21 - 1].ToString().Trim(),
                        Phone = item[22 - 1].ToString().Trim(),
                        Note = item[23 - 1].ToString().Trim(),
                        Year = year,
                        Batch = batch

                    };
                    datas.Add(tmp);
                }
                catch (System.FormatException)
                {

                }

            }
            return datas;
        }
        public static List<BankAccount> DataTableToBankAccount(DataTable data)
        {
            List<BankAccount> datas = new List<BankAccount>();
            foreach (DataRow item in data.Rows)
            {
                //var dd = item[0-1];
                try
                {
                    var tmp = new BankAccount
                    {
                        CmndNumber = item[0].ToString().Trim().Trim(),
                        Beneficiaries = item[1].ToString().Trim(),
                        NumberAccount = item[2].ToString().Trim(),
                        Bank = item[3].ToString().Trim(),
                        Created = DateTime.Now
                    };
                    datas.Add(tmp);
                }
                catch (System.FormatException)
                {

                }

            }
            return datas;
        }
    }
}
