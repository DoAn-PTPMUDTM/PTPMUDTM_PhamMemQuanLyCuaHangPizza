# Thành viên
<h4>Tên nhóm: ĐL-VT  </h4>

>>**Thầy  Bùi Công Danh**
  
| STT | Họ tên | Chức vụ  |
|----------------|--------------------|--------------------|
|  1  |  Huỳnh Văn Tiên  |   Nhóm trưởng  |
|  2  |  Nguyễn Ngọc Bảo  |   Thành viên  |
|  3  |  Nguyễn Mạnh Tiến  |   Thành viên  |
-----------------------------------------------
### Sử dụng 
 - .Net Framework version 4.5
 - Visual studio 2013
-----------------------------------------------

### Chi tiết
<img src="https://i.imgur.com/FehXExF.jpg">

-----------------------------------------------
<!DOCTYPE html>
<html lang="vi">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Quản Lý Cửa Hàng Pizza</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f8f9fa;
            color: #343a40;
            margin: 0;
            padding: 0;
        }

        header {
            background-color: #dc3545;
            color: white;
            padding: 20px;
            text-align: center;
        }

        h1 {
            margin: 0;
        }

        .container {
            max-width: 1200px;
            margin: 20px auto;
            padding: 20px;
            background-color: white;
            box-shadow: 0 0 15px rgba(0, 0, 0, 0.1);
        }

        h2 {
            color: #dc3545;
            border-bottom: 2px solid #dc3545;
            padding-bottom: 10px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin: 20px 0;
        }

        th, td {
            padding: 12px;
            text-align: left;
            border-bottom: 1px solid #dee2e6;
        }

        th {
            background-color: #dc3545;
            color: white;
        }

        ul {
            list-style-type: square;
            margin-left: 20px;
        }

        .highlight {
            color: #28a745;
            font-weight: bold;
        }

        footer {
            text-align: center;
            padding: 10px;
            background-color: #dc3545;
            color: white;
            margin-top: 20px;
        }

        .assigned {
            font-weight: bold;
            color: #007bff;
        }

        .card {
            background-color: #e9ecef;
            padding: 20px;
            margin-bottom: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
    </style>
</head>
<body>

<header>
    <h1>Quản Lý Cửa Hàng Pizza</h1>
</header>

<div class="container">
    <h2>Mô tả dự án</h2>
    <div class="card">
        <p>
            Phần mềm quản lý cửa hàng pizza là hệ thống ứng dụng đa nền tảng, hỗ trợ quản lý đơn hàng, thông tin sản phẩm, khách hàng, 
            và thanh toán, mang lại trải nghiệm tiện lợi cho cả khách hàng và quản lý cửa hàng. 
            Người dùng có thể <span class="highlight">tìm kiếm, đặt hàng, và thanh toán trực tuyến</span>, 
            trong khi nhân viên quản lý có thể dễ dàng kiểm soát thông tin cửa hàng qua ứng dụng.
        </p>
    </div>

    <h2>Nghiệp vụ và Phân công</h2>
    <table>
        <thead>
            <tr>
                <th>STT</th>
                <th>Nghiệp vụ</th>
                <th>Phân công</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>1</td>
                <td>Tìm kiếm pizza theo tên, loại, giá</td>
                <td class="assigned">Tiên</td>
            </tr>
            <tr>
                <td>2</td>
                <td>Đăng nhập, đăng ký tài khoản khách hàng</td>
                <td class="assigned">Tiến</td>
            </tr>
            <tr>
                <td>3</td>
                <td>Xem thông tin pizza (chi tiết, đánh giá, bộ lọc)</td>
                <td class="assigned">Tiên</td>
            </tr>
            <tr>
                <td>4</td>
                <td>Quản lý tài khoản khách hàng</td>
                <td class="assigned">Bảo</td>
            </tr>
            <tr>
                <td>5</td>
                <td>Đặt hàng pizza</td>
                <td class="assigned">Bảo</td>
            </tr>
            <tr>
                <td>6</td>
                <td>Thanh toán</td>
                <td class="assigned">Bảo</td>
            </tr>
            <tr>
                <td>7</td>
                <td>Đánh giá món ăn</td>
                <td class="assigned">Bảo</td>
            </tr>
        </tbody>
    </table>

    <h2>Chức năng chính</h2>
    <div class="card">
        <h3>Website</h3>
        <ul>
            <li>Tìm kiếm pizza theo tên, loại, giá.</li>
            <li>Hiển thị thông tin chi tiết về từng món pizza.</li>
            <li>Thêm pizza vào giỏ hàng và thanh toán trực tuyến.</li>
            <li>Quản lý tài khoản khách hàng: thông tin cá nhân, đơn hàng, món yêu thích.</li>
        </ul>
    </div>

    <div class="card">
        <h3>Ứng dụng Winform</h3>
        <ul>
            <li>Quản lý sản phẩm: thêm/cập nhật pizza, đồ uống.</li>
            <li>Quản lý khách hàng và tra cứu thông tin.</li>
            <li>Quản lý nhân viên, phân quyền và báo cáo doanh thu.</li>
            <li>Thống kê sản phẩm bán chạy nhất trong tháng.</li>
        </ul>
    </div>
</div>

<footer>
    <p>&copy; 2024 Quản Lý Cửa Hàng Pizza | Nhóm: Tiên, Tiến, Bảo</p>
</footer>

</body>
</html>

Thống kê</p>
<ul>
<li>Doanh thu </li>
<li> Đơn hàng theo ngày theo tháng, theo năm</li></li>
</ul>

