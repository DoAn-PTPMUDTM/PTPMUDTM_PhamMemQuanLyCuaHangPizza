USE [ProjectWeb]
GO
/****** Object:  Table [dbo].[about]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[about](
	[about_id] [int] IDENTITY(1,1) NOT NULL,
	[content] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[about_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cart_items]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cart_items](
	[cart_item_id] [int] IDENTITY(1,1) NOT NULL,
	[cart_id] [int] NULL,
	[product_id] [int] NULL,
	[quantity] [int] NULL,
	[total_price] [decimal](10, 2) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cart_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[carts]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[carts](
	[cart_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[total_price] [decimal](10, 2) NULL,
	[total_quantity] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[cart_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [nvarchar](255) NULL,
	[description] [nvarchar](max) NULL,
	[status] [varchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comment]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comment](
	[comment_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[product_id] [int] NULL,
	[content] [nvarchar](max) NULL,
	[comment_date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[comment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_items]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_items](
	[order_item_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NULL,
	[product_id] [int] NULL,
	[quantity] [int] NULL,
	[total_price] [decimal](10, 2) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[orders]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[shipping_address] [nvarchar](255) NULL,
	[phone_number] [nvarchar](20) NULL,
	[full_name] [nvarchar](255) NULL,
	[total_price] [decimal](10, 2) NULL,
	[total_quantity] [int] NULL,
	[status] [varchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[policy]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[policy](
	[policy_id] [int] IDENTITY(1,1) NOT NULL,
	[policy_content] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[policy_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [nvarchar](255) NULL,
	[price] [decimal](10, 2) NULL,
	[stock] [int] NULL,
	[description] [nvarchar](max) NULL,
	[product_image] [nvarchar](2000) NULL,
	[category_id] [int] NULL,
	[status] [varchar](50) NULL,
	[sold] [int] NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rating]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rating](
	[rate_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[product_id] [int] NULL,
	[rate] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[rate_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[slider]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[slider](
	[slider_id] [int] IDENTITY(1,1) NOT NULL,
	[slider_img] [nvarchar](max) NULL,
	[position] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[slider_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/5/2024 10:30:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](255) NULL,
	[password] [nvarchar](255) NULL,
	[full_name] [nvarchar](255) NULL,
	[role] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[about] ON 

INSERT [dbo].[about] ([about_id], [content]) VALUES (1, N'<div class="container">
        <div class="row ">
            <div class="col-md-12">
                <h1 class="wp-block-heading"><strong>CHÍNH SÁCH BẢO MẬT THÔNG TIN:</strong></h1>
                <h2>1. Mục đích thu thập thông tin cá nhân</h2>
                <p>Mục đích của việc thu thập thông tin khách hàng nhằm liên quan đến các vấn đề như:</p>
                <ul>
                    <li>Hỗ trợ khách hàng: tư vấn các dịch vụ của chúng tôi.</li>
                    <li>Cung cấp thông tin các dịch vụ và hỗ trợ theo yêu cầu của khách hàng.</li>
                    <li>Gửi thông báo các chương trình, dịch vụ mới nhất của chúng tôi.</li>
                    <li>Giải quyết vấn đề phát sinh khi sử dụng dịch vụ.</li>
                    <li>Ngăn chặn các hoạt động phạm pháp.</li>
                    <li>Đo lường và cải thiện các dịch vụ của chúng tôi.</li>
                </ul>
                <h2>2. Phạm vi thu thập thông tin</h2>
                <p>Chúng tôi thu thập thông tin cá nhân của khách hàng khi:</p>
                <ul>
                    <li>Khách hàng trực tiếp cung cấp: Khách hàng trực tiếp cung cấp bao gồm: họ tên, địa chỉ email, số
                        điện
                        thoại, địa chỉ.</li>
                    <li>Khách hàng tương tác với chúng tôi: Chúng tôi sử dụng cookies và công nghệ theo dấu khác để thu
                        thập
                        một số thông tin khi khách hàng tương tác trên website</li>
                    <li>Từ những nguồn hợp pháp khác: Chúng tôi thu thập thông tin khách hàng từ các nguồn hợp pháp
                        khác.
                    </li>
                </ul>
                <h2>3. Thời gian lưu trữ thông tin</h2>
                <p>Cửa hàng Pizza sẽ lưu trữ thông tin cá nhân trên hệ thống nội bộ trong suốt quá trình cung cấp dịch vụ hoặc cho đến khi khách hàng yêu cầu hủy thông tin đã cung cấp.</p>
                <h2>4. Những người hoặc tổ chức có thể được tiếp cận với thông tin đó</h2>
                <p>– Các đối tác là bên cung cấp dịch vụ cho chúng tôi liên quan đến thực hiện đơn hàng và chỉ giới hạn
                    trong phạm vi thông tin cần thiết cũng như áp dụng các quy định đảm bảo an ninh, bảo mật các thông
                    tin
                    cá nhân.</p>
                <p>– Chúng tôi sử dụng dịch vụ từ một nhà cung cấp dịch vụ là bên thứ ba để thực hiện một số hoạt động
                    liên
                    quan đến website. Khi đó, bên thứ ba có thể truy cập hoặc xử lý các thông tin cá
                    nhân
                    trong quá trình cung cấp các dịch vụ đó. Chúng tôi yêu cầu các bên thứ ba này tuân thủ mọi luật lệ
                    về
                    bảo vệ thông tin cá nhân liên quan và các yêu cầu về an ninh liên quan đến thông tin cá nhân.</p>
                <p>– Các chương trình có tính liên kết, đồng thực hiện, thuê ngoài cho các mục đích được nêu tại Mục 1
                    và
                    luôn áp dụng các yêu cầu bảo mật thông tin cá nhân.</p>
                <p>– Yêu cầu pháp lý: Chúng tôi có thể tiết lộ các thông tin cá nhân nếu điều đó do luật pháp yêu cầu và
                    việc tiết lộ như vậy là cần thiết một cách hợp lý để tuân thủ các quy trình pháp lý.</p>
                <p>– Chuyển giao kinh doanh (nếu có): trong trường hợp sáp nhập, hợp nhất toàn bộ hoặc một phần với công
                    ty
                    khác, người mua sẽ có quyền truy cập thông tin được chúng tôi lưu trữ, duy trì trong đó bao gồm cả
                    thông
                    tin cá nhân.</p>
                <h2>5. Địa chỉ của đơn vị thu thập và quản lý thông tin</h2>
                <ul>
                    <li>ên doanh nghiệp: Cửa hàng Pizza</li>
                    <li>Trụ sở chính: 140 Lê Trọng Tấn, Tây Thạnh, Thành phố Hồ Chí Minh
                    </li>
                </ul>
                <h2>6. Phương thức và công cụ để người dùng tiếp cận và chỉnh sửa dữ liệu:</h2>
                <p>Nếu quý khách có bất cứ về yêu cầu nào về việc tiếp cận và chỉnh sửa thông tin cá nhân đã cung cấp,
                    quý
                    khách có thể:</p>
                <ul>
                    <li>Gọi điện trực tiếp về số điện thoại: <a href="tel:0916400858">091.0501.664</a></li>
                    <li>Gửi mail:</li>
                    <li><a href="mailto:contact@pizzahub.vn">support@pizza.vn</a></li>
                </ul>
            </div>
        </div>
    </div>')
SET IDENTITY_INSERT [dbo].[about] OFF
GO
SET IDENTITY_INSERT [dbo].[categories] ON 

INSERT [dbo].[categories] ([category_id], [category_name], [description], [status], [created_at], [updated_at]) VALUES (1, N'Pizza hải sản', N'ngon', N'active', CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:27:02.230' AS DateTime))
INSERT [dbo].[categories] ([category_id], [category_name], [description], [status], [created_at], [updated_at]) VALUES (2, N'Pizza gà', N'', N'active', CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:06:13.810' AS DateTime))
INSERT [dbo].[categories] ([category_id], [category_name], [description], [status], [created_at], [updated_at]) VALUES (3, N'Pizza bò', N'', N'active', CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:06:13.810' AS DateTime))
INSERT [dbo].[categories] ([category_id], [category_name], [description], [status], [created_at], [updated_at]) VALUES (4, N'Pizza heo', N'', N'active', CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:06:13.810' AS DateTime))
INSERT [dbo].[categories] ([category_id], [category_name], [description], [status], [created_at], [updated_at]) VALUES (5, N'Nước ', N'Sảng khoái', N'active', CAST(N'2024-12-05T10:16:32.697' AS DateTime), CAST(N'2024-12-05T10:27:18.037' AS DateTime))
SET IDENTITY_INSERT [dbo].[categories] OFF
GO
SET IDENTITY_INSERT [dbo].[policy] ON 

INSERT [dbo].[policy] ([policy_id], [policy_content]) VALUES (1, N'<h4>Chính sách:</h4>
                    <div class="flex w-full flex-col gap-1 empty:hidden first:pt-[3px]">
<div class="markdown prose w-full break-words dark:prose-invert light">
<ol>
<li><strong>Khu Vực Giao Hàng</strong>
<ul>
<li>Nhà hàng hỗ trợ giao hàng trong phạm vi 10 km tính từ địa chỉ của nhà hàng. Đối với các khu vực xa hơn, vui lòng liên hệ trực tiếp để được hỗ trợ.</li>
</ul>
</li>
<li><strong>Thời Gian Giao Hàng</strong>
<ul>
<li>Giao hàng từ 10:00 – 22:00 hàng ngày. Thời gian giao hàng trung bình là từ 30-45 phút, tuỳ thuộc vào khoảng cách và lưu lượng giao thông.</li>
</ul>
</li>
<li><strong>Phí Giao Hàng</strong>
<ul>
<li>Phí giao hàng sẽ được tính dựa trên khoảng cách và sẽ được thông báo cho khách hàng trước khi xác nhận đơn hàng.</li>
</ul>
</li>
<li><strong>Chính Sách Đổi Trả</strong>
<ul>
<li>Nếu sản phẩm giao đến không đúng yêu cầu hoặc bị hư hỏng trong quá trình vận chuyển, nhà hàng sẽ hỗ trợ đổi món mới hoặc hoàn tiền nếu cần thiết.</li>
<li>Khách hàng vui lòng kiểm tra đơn hàng ngay khi nhận. Nếu có bất kỳ vấn đề nào, vui lòng liên hệ hotline trong vòng 30 phút để được hỗ trợ kịp thời.</li>
</ul>
</li>
<li><strong>Ưu Đãi Giao Hàng</strong>
<ul>
<li>Nhà hàng thường xuyên có các ưu đãi cho khách hàng đặt hàng online. Vui lòng theo dõi website và fanpage của chúng tôi để cập nhật các chương trình khuyến mãi.</li>
</ul>
</li>
</ol>
<p><strong>Liên Hệ</strong><br>
Nếu cần hỗ trợ hoặc có thắc mắc về đơn hàng, vui lòng gọi vào hotline <a href="tel:0916400858">091.6400.858</a></p>
</div>
</div><div class="row">
                                <div class="col-md-12">


                                    <div>
                                      <p>Nhà Hàng Pizza luôn cam kết mang đến chất lượng dịch vụ tốt nhất và đảm bảo quyền lợi cho quý khách hàng. Dưới đây là chi tiết về chính sách đổi trả hàng tại Nhà Hàng Pizza nhằm giúp khách hàng nắm rõ hơn về quy trình và điều kiện đổi trả:</p>
<p><strong>Điều kiện đổi trả sản phẩm:</strong></p>
<ul>
<li>Khách hàng có quyền yêu cầu đổi trả trong vòng 2 giờ kể từ khi nhận sản phẩm.</li>
<li>Sản phẩm phải còn nguyên vẹn, không bị hư hỏng, trầy xước hoặc biến dạng do các yếu tố không phải lỗi kỹ thuật từ nhà hàng.</li>
<li>Sản phẩm phải còn đầy đủ các phụ kiện kèm theo (nếu có) như hộp đựng, bao bì và các vật dụng trang trí đi kèm ban đầu.</li>
</ul>
<p><strong>Quy trình đổi trả sản phẩm:</strong></p>
<ol>
<li>Khách hàng vui lòng liên hệ trực tiếp với bộ phận chăm sóc khách hàng của Nhà Hàng Pizza qua hotline hoặc tại quầy.</li>
<li>Sau khi tiếp nhận thông tin từ khách hàng, nhân viên của nhà hàng sẽ tiến hành kiểm tra sản phẩm để xác nhận tình trạng và lý do đổi trả.</li>
<li>Nếu sản phẩm đạt đủ điều kiện đổi trả, Nhà Hàng Pizza sẽ hỗ trợ đổi sản phẩm mới cùng loại cho khách hàng.</li>
<li>Trong trường hợp không có sản phẩm thay thế, Nhà Hàng Pizza sẽ đề xuất phương án hoàn tiền hoặc phiếu mua hàng có giá trị tương đương.</li>
</ol>
<p><strong>Lưu ý:</strong></p>
<ul>
<li>Chính sách đổi trả này chỉ áp dụng cho các sản phẩm được mua trực tiếp tại nhà hàng và không bao gồm các sản phẩm có dấu hiệu đã bị sử dụng hoặc bị hư hỏng do lỗi của khách hàng.</li>
<li>Khách hàng vui lòng giữ lại hóa đơn mua hàng để đảm bảo quyền lợi khi đổi trả sản phẩm.</li>
</ul>
<p>Nếu có bất kỳ thắc mắc hay cần hỗ trợ thêm về chính sách đổi trả, xin vui lòng liên hệ với Nhà Hàng Pizza qua số hotline hoặc đến trực tiếp tại nhà hàng.</p>
                                    </div>
                                </div>
                            </div>')
SET IDENTITY_INSERT [dbo].[policy] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (1, N'Pizza hải sản cao cấp', CAST(249000.00 AS Decimal(10, 2)), 20, N'Pizza hải sản cao cấp với tôm, mực và phô mai mozzarella', N'~/Content/images/1.png', 1, N'active', 10, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:10:24.507' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (2, N'Pizza hải sản nhiệt đới', CAST(199000.00 AS Decimal(10, 2)), 15, N'Pizza với tôm và dứa, hòa quyện hương vị chua ngọt', N'~/Content/images/2.png', 1, N'active', 5, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:10:30.750' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (3, N'Pizza hải sản sốt cay', CAST(229000.00 AS Decimal(10, 2)), 10, N'Pizza hải sản với sốt cay đặc trưng', N'~/Content/images/3.png', 1, N'active', 8, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:10:36.500' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (4, N'Pizza tôm phô mai', CAST(259000.00 AS Decimal(10, 2)), 18, N'Tôm tươi phủ phô mai béo ngậy', N'~/Content/images/4.png', 1, N'active', 12, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:10:42.950' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (5, N'Pizza mực cay', CAST(189000.00 AS Decimal(10, 2)), 12, N'Pizza mực tươi với ớt cay nồng', N'~/Content/images/5.png', 1, N'active', 6, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:11:08.090' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (6, N'Pizza gà phô mai', CAST(199000.00 AS Decimal(10, 2)), 25, N'Pizza gà với phô mai mozzarella', N'~/Content/images/6.png', 2, N'active', 15, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:11:14.993' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (7, N'Pizza gà BBQ', CAST(209000.00 AS Decimal(10, 2)), 18, N'Pizza gà với sốt BBQ thơm lừng', N'~/Content/images/7.png', 2, N'active', 10, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:11:25.600' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (8, N'Pizza gà nướng mật ong', CAST(229000.00 AS Decimal(10, 2)), 10, N'Pizza gà nướng mật ong ngọt dịu', N'~/Content/images/8.png', 2, N'active', 9, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:11:37.183' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (9, N'Pizza gà xé cay', CAST(189000.00 AS Decimal(10, 2)), 20, N'Pizza gà xé cay đậm đà hương vị', N'~/Content/images/9.png', 2, N'active', 11, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:11:46.930' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (10, N'Pizza gà nấm', CAST(219000.00 AS Decimal(10, 2)), 15, N'Pizza gà kết hợp nấm tươi và phô mai', N'~/Content/images/10.png', 2, N'active', 7, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:11:56.913' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (11, N'Pizza bò truyền thống', CAST(209000.00 AS Decimal(10, 2)), 22, N'Pizza bò với thịt bò tươi và phô mai', N'~/Content/images/11.png', 3, N'active', 13, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:12:18.627' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (12, N'Pizza bò sốt tiêu đen', CAST(239000.00 AS Decimal(10, 2)), 17, N'Pizza bò sốt tiêu đen đậm đà', N'~/Content/images/12.png', 3, N'active', 9, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:12:29.707' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (13, N'Pizza bò nướng', CAST(249000.00 AS Decimal(10, 2)), 12, N'Thịt bò nướng thơm lừng trên lớp phô mai tan chảy', N'~/Content/images/13.png', 3, N'active', 10, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:12:53.877' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (14, N'Pizza bò cay Mexico', CAST(229000.00 AS Decimal(10, 2)), 10, N'Pizza bò cay với hương vị Mexico', N'~/Content/images/14.png', 3, N'active', 8, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:13:15.787' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (15, N'Pizza bò phô mai cheddar', CAST(219000.00 AS Decimal(10, 2)), 18, N'Pizza bò với phô mai cheddar thơm béo', N'~/Content/images/15.png', 3, N'active', 6, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:13:27.530' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (16, N'Pizza heo truyền thống', CAST(199000.00 AS Decimal(10, 2)), 20, N'Pizza với thịt heo và phô mai', N'~/Content/images/16.png', 4, N'active', 12, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:13:39.620' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (17, N'Pizza heo nướng mật ong', CAST(229000.00 AS Decimal(10, 2)), 15, N'Pizza heo nướng mật ong thơm lừng', N'~/Content/images/17.png', 4, N'active', 9, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:13:48.957' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (18, N'Pizza heo xông khói', CAST(239000.00 AS Decimal(10, 2)), 12, N'Pizza với thịt heo xông khói và phô mai', N'~/Content/images/18.png', 4, N'active', 7, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:14:02.577' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (19, N'Pizza xúc xích heo', CAST(189000.00 AS Decimal(10, 2)), 25, N'Pizza với xúc xích heo và sốt cà chua', N'~/Content/images/19.png', 4, N'active', 10, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:14:11.813' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (20, N'Pizza heo sốt BBQ', CAST(219000.00 AS Decimal(10, 2)), 10, N'Pizza thịt heo sốt BBQ ngọt dịu', N'~/Content/images/20.png', 4, N'active', 5, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:14:23.240' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (21, N'Pizza heo cay', CAST(209000.00 AS Decimal(10, 2)), 18, N'Pizza với thịt heo cay nồng và phô mai', N'~/Content/images/21.png', 4, N'active', 8, CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:14:31.707' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (22, N'Nước ngọt Coca-Cola', CAST(15000.00 AS Decimal(10, 2)), 50, N'Nước ngọt Coca-Cola tươi mát', N'~/Content/images/coca.jpg', 5, N'active', 20, CAST(N'2024-12-05T10:23:27.063' AS DateTime), CAST(N'2024-12-05T10:24:02.953' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (23, N'Nước ngọt Pepsi', CAST(15000.00 AS Decimal(10, 2)), 40, N'Nước ngọt Pepsi sảng khoái', N'~/Content/images/category_1724251421.png', 5, N'active', 18, CAST(N'2024-12-05T10:23:27.063' AS DateTime), CAST(N'2024-12-05T10:24:13.513' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (24, N'Nước FANTA', CAST(15000.00 AS Decimal(10, 2)), 30, N'Nước chanh dây tươi mát', N'~/Content/images/fanta.jpg', 5, N'active', 10, CAST(N'2024-12-05T10:23:27.063' AS DateTime), CAST(N'2024-12-05T10:24:23.890' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (25, N'Nước Sprite', CAST(15000.00 AS Decimal(10, 2)), 25, N'Nước cam ép nguyên chất', N'~/Content/images/spri.jpg', 5, N'active', 12, CAST(N'2024-12-05T10:23:27.063' AS DateTime), CAST(N'2024-12-05T10:24:44.583' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (26, N'Nước khoáng Lavie', CAST(10000.00 AS Decimal(10, 2)), 60, N'Nước khoáng tinh khiết Lavie', N'~/Content/images/lavi.png', 5, N'active', 25, CAST(N'2024-12-05T10:23:27.063' AS DateTime), CAST(N'2024-12-05T10:24:59.270' AS DateTime))
INSERT [dbo].[products] ([product_id], [product_name], [price], [stock], [description], [product_image], [category_id], [status], [sold], [created_at], [updated_at]) VALUES (27, N'Nước 7UP', CAST(15000.00 AS Decimal(10, 2)), 20, N'Nước ép trái cây hỗn hợp tươi ngon', N'~/Content/images/UtRXMZxXlelviPXRRP5RmDaAwUXNd2sFLgwwJlNS.png', 5, N'active', 8, CAST(N'2024-12-05T10:23:27.063' AS DateTime), CAST(N'2024-12-05T10:25:08.677' AS DateTime))
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[slider] ON 

INSERT [dbo].[slider] ([slider_id], [slider_img], [position]) VALUES (1, N'~/Content/images/5-pizza-mat-ong-1.jpg', 1)
INSERT [dbo].[slider] ([slider_id], [slider_img], [position]) VALUES (2, N'~/Content/images/images.jpg', 2)
INSERT [dbo].[slider] ([slider_id], [slider_img], [position]) VALUES (3, N'~/Content/images/3-pizza-pamaham.jpg', 3)
SET IDENTITY_INSERT [dbo].[slider] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([user_id], [email], [password], [full_name], [role], [status], [created_at], [updated_at]) VALUES (1, N'admin@gmail.com', N'1234QW!r', N'admin', N'admin', N'active', CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:06:13.810' AS DateTime))
INSERT [dbo].[users] ([user_id], [email], [password], [full_name], [role], [status], [created_at], [updated_at]) VALUES (2, N'user1@example.com', N'1234QW!r', N'User 1', N'user', N'active', CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:06:13.810' AS DateTime))
INSERT [dbo].[users] ([user_id], [email], [password], [full_name], [role], [status], [created_at], [updated_at]) VALUES (3, N'user2@example.com', N'1234QW!r', N'User 2', N'user', N'active', CAST(N'2024-12-05T10:06:13.810' AS DateTime), CAST(N'2024-12-05T10:06:13.810' AS DateTime))
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[cart_items] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[cart_items] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[carts] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[carts] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[categories] ADD  DEFAULT ('active') FOR [status]
GO
ALTER TABLE [dbo].[categories] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[categories] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[comment] ADD  DEFAULT (getdate()) FOR [comment_date]
GO
ALTER TABLE [dbo].[order_items] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[order_items] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[orders] ADD  DEFAULT ('pending') FOR [status]
GO
ALTER TABLE [dbo].[orders] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[orders] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT ((0)) FOR [stock]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT ('active') FOR [status]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT ((0)) FOR [sold]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[products] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ('user') FOR [role]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ('active') FOR [status]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT (getdate()) FOR [updated_at]
GO
ALTER TABLE [dbo].[cart_items]  WITH CHECK ADD FOREIGN KEY([cart_id])
REFERENCES [dbo].[carts] ([cart_id])
GO
ALTER TABLE [dbo].[cart_items]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
GO
ALTER TABLE [dbo].[carts]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[comment]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
GO
ALTER TABLE [dbo].[comment]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[order_items]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([order_id])
GO
ALTER TABLE [dbo].[order_items]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([category_id])
GO
ALTER TABLE [dbo].[rating]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([product_id])
GO
ALTER TABLE [dbo].[rating]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[users] ([user_id])
GO
