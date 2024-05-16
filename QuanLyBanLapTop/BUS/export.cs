
using DAO;
using DTO;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class export
    {
        
        public static void exportBillExcel(HoaDon bill, List<ChiTietHoaDonDTO> listDt, List<SanPham> listP)
        {
            
            // khởi tạo wb rỗng
            XSSFWorkbook wb = new XSSFWorkbook();

            // Tạo ra 1 sheet
            ISheet sheet = wb.CreateSheet();

            // Bắt đầu ghi lên sheet

            // Tạo row
            var row0 = sheet.CreateRow(5);
            // Merge lại row đầu 3 cột
            row0.CreateCell(5); // tạo ra cell trc khi merge
            CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
            sheet.AddMergedRegion(cellMerge);
            row0.GetCell(5).SetCellValue("Thông tin hoá đơn" + bill.IdBill);

            // Ghi tên cột ở row 1
            var row1 = sheet.CreateRow(6);
            row1.CreateCell(4).SetCellValue("Tên sản phẩm");
            row1.CreateCell(5).SetCellValue("Số lượng mua");
            row1.CreateCell(6).SetCellValue("Đơn giá");
            row1.CreateCell(7).SetCellValue("Tiền đã giảm");
            row1.CreateCell(8).SetCellValue("Thành tiền");
            // bắt đầu duyệt mảng và ghi tiếp tục
            int rowIndex = 7;
            for(int i = 0; i < listDt.Count; i++)
            {
                var rowInd = sheet.CreateRow(rowIndex);
                rowInd.CreateCell(4).SetCellValue(listP[i].NameProduct+"");
                rowInd.CreateCell(5).SetCellValue(listDt[i].QuantityProduct+"");
                rowInd.CreateCell(6).SetCellValue(listP[i].UnitPrice.ToString("0.0") + "");
                rowInd.CreateCell(7).SetCellValue(listDt[i].MoneyDown.ToString("0.0") + "");
                rowInd.CreateCell(8).SetCellValue((listDt[i].IntoMoney- listDt[i].MoneyDown).ToString("0.0")+"");
                rowIndex++;
            }
            var rowNext = sheet.CreateRow(rowIndex);
            rowNext.CreateCell(7).SetCellValue("Tổng thanh toán");
            rowNext.CreateCell(8).SetCellValue(bill.Pay);

            rowIndex++;
            rowNext = sheet.CreateRow(rowIndex);
            rowNext.CreateCell(4).SetCellValue("Ngày thanh toán");
            rowNext.CreateCell(5).SetCellValue(bill.DateBill.ToString());

            rowIndex++;
            rowNext = sheet.CreateRow(rowIndex);
            rowNext.CreateCell(4).SetCellValue("Nhân viên thực hiện");
            
            rowNext.CreateCell(5).SetCellValue(new NhanVienDao().searchEmployee(bill.IdEmployee).Name);
            // xong hết thì save file lại
            FileStream fs = new FileStream(@"E:\Workspace\C#\myProject\DoAnC-_QuanLyBanLapTop\Excel\Bill\HoaDon_" + bill.IdBill +".xlsx", FileMode.CreateNew);
            wb.Write(fs);
        }
        public static string exportExcelPromotion(Dictionary<string,string> listDetails, string name )
        {
            
            try
            {
                // khởi tạo wb rỗng
                XSSFWorkbook wb = new XSSFWorkbook();

                // Tạo ra 1 sheet
                ISheet sheet = wb.CreateSheet();

                // Bắt đầu ghi lên sheet

                // Tạo row
                var row0 = sheet.CreateRow(5);
                // Merge lại row đầu 3 cột
                row0.CreateCell(5); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
                sheet.AddMergedRegion(cellMerge);
                row0.GetCell(5).SetCellValue("Thông tin khuyến mãi " + name);

                // Ghi tên cột ở row 1
                var row1 = sheet.CreateRow(6);
                row1.CreateCell(4).SetCellValue("Tên sản phẩm");
                row1.CreateCell(5).SetCellValue("% giảm giá");

                // bắt đầu duyệt mảng và ghi tiếp tục
                int rowIndex = 7;
                foreach (var value in listDetails)
                {
                    var rowInd = sheet.CreateRow(rowIndex);
                    rowInd.CreateCell(4).SetCellValue(value.Key);
                    rowInd.CreateCell(5).SetCellValue(value.Value);
                    rowIndex++;
                }
                // xong hết thì save file lại
                FileStream fs = new FileStream(@"E:\Workspace\C#\myProject\DoAnC-_QuanLyBanLapTop\Excel\Promotion\KhuyenMai_" + name + ".xlsx", FileMode.CreateNew);
                wb.Write(fs);
            }catch(Exception e)
            {
                return "error";
            }
            return "success";
        }
    }
}
