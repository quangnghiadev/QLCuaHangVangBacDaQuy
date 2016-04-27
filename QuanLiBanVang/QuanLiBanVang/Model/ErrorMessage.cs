﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.Model
{
    public class ErrorMessage
    {
        public static readonly string ERROR_MESSARE_TITLE = "Lỗi";
        public static readonly string CLIENT_INVALID_INPUT_MESSAGE = "Thông tin nhập không hợp lệ. Vui lòng kiểm tra dữ liệu !!";
        public static readonly string EXISTED_PRODUCT_MESSAGE = "Sản phẩm đã tồn tại trong phiếu !!";
        public static readonly string EMPTY_DETAILS_ERR_MESSAGE = "Chi tiết cho phiếu bán hàng còn trống !";
        public static readonly string OVER_IN_STOCK_MESSAGE = "Quá số lượng tồn kho cho sản phầm này !";
        public static readonly string INVALID_INPUT_RECEIPT_DATE = "Ngày lập hóa đơn phải trước hoặc cùng ngày thanh toán!";
        public static readonly string OVER_LIMITATION_FOR_IMPORTING = "Quá số lượng tối đa cho phép !";
        public static readonly string NO_DETALI_FOR_RECEIPT = "Không có chi tiết nào cho phiếu ?";
        public static readonly string EXISTED_PROVIDER_IN_DATABASE = "Nhà cung cấp này đã tồn tại trong dữ liệu";
    }
}