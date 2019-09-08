
$(document).ready(function () {
    $(function () {
        $(".cap1").click(function () {
            $(this).next().slideToggle();
        });
    });
    $(function () {
        $("#btnSubmit").click(function () {
            var loi = 0;
            if ($("#HoTen").val() == "") {
                $("#loiHoTen").text("Trống Họ Tên !");
                loi++;
            }
            else {
                    $("#hopleHoTen").text("Hợp Lệ");
                }
            if ($("#TaiKhoan").val() == "") {
                $("#loiTaiKhoan").text("Trống Tài Khoản !");
                loi++;
            }
            else {
                $("#hopleTaiKhoan").text("Hợp Lệ");
            }
            if ($("#MatKhau").val() == "") {
                $("#loiMatKhau").text("Trống Mật Khẩu !");
                loi++;
            }
            else {
                $("#hopleMatKhau").text("Hợp Lệ");
            }
            if ($("#Email").val() == "") {
                $("#loiEmail").text("Trống Email !");
                loi++;
            }
            else {
                $("#hopleEmail").text("Hợp Lệ");
            }
            if ($("#DiaChi").val() == "") {
                $("#loiDiaChi").text("Trống Địa Chỉ !");
                loi++;
            }
            else {
                $("#hopleDiaChi").text("Hợp Lệ");
            }
            if ($("#DienThoai").val() == "") {
                $("#loiDienThoai").text("Trống Điện Thoại !");
                loi++;
            }
            else {
                $("#hopleDienThoai").text("Hợp Lệ");
            }
            if ($("#GioiTinh").val() == "") {
                $("#loiGioiTinh").text("Trống Giới Tính !");
                loi++;
            }
            else {
                $("#hopleGioiTinh").text("Hợp Lệ");
            }
            if ($("#NgaySinh").val() == "") {
                $("#loiNgaySinh").text("Trống Ngày Sinh !");
                loi++;
            }
            else {
                $("#hopleNgaySinh").text("Hợp Lệ");
            }

            if (loi != 0) {
                return false;
            }
            else {
                return true;
            }
        });
    });
    
 });

   
   