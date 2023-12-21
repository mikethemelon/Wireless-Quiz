using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapQTMang
{
    public partial class Form1 : Form
    {
        private List<Question> questions;
        private Random random;
        private Question currentQuestion;

        public Form1()
        {
            InitializeComponent();

            // Initialize the list of questions
            questions = new List<Question>
            {
             new Question("1. Wireless LAN (WLAN) là gì? ", "Mạng không dây", new List<string> { "Mạng không dây", "Mạng dây", "Mạng di động", "Mạng LAN cáp quang" } ),
new Question("2. Định nghĩa SSID trong mạng không dây là gì? ", "Tên của một mạng không dây", new List<string> { "Tên của một mạng không dây", "Một địa chỉ IP động", "Một loại mã hóa mạng", "Giao thức kết nối mạng" } ),
new Question("3. Chuẩn Wi-Fi nào hoạt động trên băng tần 2.4GHz? ", "802.11g", new List<string> { "802.11g", "802.11ac", "802.11n", "802.11ax" } ),
new Question("4. Mục đích chính của WEP và WPA trong mạng không dây là gì? ", "Mã hóa dữ liệu truyền qua mạng", new List<string> { "Mã hóa dữ liệu truyền qua mạng", "Định danh các thiết bị trong mạng", "Xác thực người dùng", "Quản lý địa chỉ IP" } ),
new Question("5. Đặc điểm nổi bật của mạng Mesh Wi-Fi là gì? ", "Sự mở rộng dễ dàng của mạng", new List<string> { "Sự mở rộng dễ dàng của mạng", "Sử dụng băng tần 5GHz", "Chỉ hỗ trợ kết nối có dây", "Tăng tốc độ truyền dữ liệu" } ),
new Question("6. Đâu là giao thức an toàn không dây được coi là mạnh nhất? ", "WPA3", new List<string> { "WPA3", "WEP", "WPA", "WPA2" } ),
new Question("7. Công nghệ nào cho phép thiết bị không dây giao tiếp với Internet thông qua điểm truy cập không dây? ", "Wi-Fi", new List<string> { "Wi-Fi", "Bluetooth", "NFC", "3G/4G" } ),
new Question("8. Đặc điểm nào được đánh giá cao trong việc lựa chọn vị trí đặt bộ phát sóng Wi-Fi? ", "Nơi có nhiều vật cản ít", new List<string> { "Nơi có nhiều vật cản ít", "Độ cao", "Gần ổ cắm điện", "Gần tường" } ),
new Question("9. Cách tốt nhất để bảo vệ mạng không dây của bạn là gì? ", "Sử dụng mật khẩu mạng mạnh", new List<string> { "Sử dụng mật khẩu mạng mạnh", "Tắt mạng khi không sử dụng", "Sử dụng cùng một mật khẩu cho nhiều thiết bị", "Để mạng không có bảo mật" } ),
new Question("10. Mesh Wi-Fi dùng để làm gì? ", "Mở rộng phạm vi mạng không dây", new List<string> { "Mở rộng phạm vi mạng không dây", "Tăng tốc độ mạng cáp quang", "Chặn tín hiệu từ các mạng không xác định", "Giảm kích thước của mạng không dây" } ),
new Question("11. IEEE 802.11ac là chuẩn nào trong mạng không dây, thường được gọi là? ", "Wi-Fi 5", new List<string> { "Wi-Fi 5", "Wi-Fi 6", "Wi-Fi 4", "Wi-Fi 7" } ),
new Question("12. Đâu là một phương pháp phát hiện và khắc phục xung đột kênh trong mạng Wi-Fi? ", "CSMA/CA", new List<string> { "CSMA/CA", "CSMA/CD", "QoS", "MIMO" } ),
new Question("13. Công nghệ MIMO trong Wi-Fi có ý nghĩa gì? ", "Tăng số lượng kết nối đồng thời", new List<string> { "Tăng số lượng kết nối đồng thời", "Tăng tốc độ tối đa của mạng", "Mở rộng phạm vi sóng Wi-Fi", "Giảm độ trễ khi truyền dữ liệu" } ),
new Question("14. Địa chỉ MAC (Media Access Control) là gì trong mạng không dây? ", "Địa chỉ vật lý duy nhất của mỗi thiết bị", new List<string> { "Địa chỉ vật lý duy nhất của mỗi thiết bị", "Địa chỉ IP của mỗi thiết bị", "Tên mạng không dây", "Mã mã hóa mạng" } ),
new Question("15. Kỹ thuật Beamforming được sử dụng trong mạng không dây để làm gì? ", "Tăng tốc độ truyền dữ liệu", new List<string> { "Tăng tốc độ truyền dữ liệu", "Mở rộng phạm vi sóng Wi-Fi", "Giảm độ trễ mạng", "Tăng cường bảo mật mạng" } ),
new Question("16. Trong mạng Mesh Wi-Fi, điểm truy cập nào có vai trò quan trọng? ", "Điểm truy cập chính (root)", new List<string> { "Điểm truy cập chính (root)", "Điểm truy cập phụ (secondary)", "Điểm truy cập tùy chỉnh (custom)", "Điểm truy cập mở rộng (extender)" } ),
new Question("17. Công nghệ nào cung cấp tốc độ truyền dữ liệu cao trong mạng không dây ở khoảng cách xa? ", "5G", new List<string> { "5G", "3G", "4G", "Bluetooth" } ),
new Question("18. Chuẩn Wi-Fi nào hỗ trợ tần số băng rộng nhất? ", "802.11ax", new List<string> { "802.11ax", "802.11b", "802.11g", "802.11n" } ),
new Question("19. Đặc điểm nào cần được xem xét khi lựa chọn vị trí đặt bộ phát sóng Wi-Fi trong một căn nhà lớn? ", "Gần trung tâm căn nhà", new List<string> { "Gần trung tâm căn nhà", "Gần khu vực có nhiều thiết bị điện tử", "Gần cửa ra vào", "Độ cao của bộ phát sóng" } ),
new Question("20. 802.11n sử dụng công nghệ nào để tăng tốc độ truyền dữ liệu? ", "Beamforming", new List<string> { "Beamforming", "MIMO", "WEP", "WPA" } ),
new Question("21. Công nghệ Roaming trong mạng Wi-Fi liên quan đến việc gì? ", "Di chuyển từ một điểm truy cập đến điểm truy cập khác mà không mất kết nối", new List<string> { "Di chuyển từ một điểm truy cập đến điểm truy cập khác mà không mất kết nối", "Chuyển đổi giữa các kênh tần số khác nhau", "Tăng cường bảo mật mạng", "Tối ưu hóa băng thông mạng" } ),
new Question("22. Điểm truy cập không dây (AP) là gì trong mạng Wi-Fi? ", "Thiết bị cho phép kết nối không dây của các thiết bị vào mạng", new List<string> { "Thiết bị cho phép kết nối không dây của các thiết bị vào mạng", "Một thiết bị để kết nối với Internet qua dây cáp", "Địa chỉ IP của mạng", "Giao thức bảo mật mạng" } ),
new Question("23. Điều gì xác định tốc độ mạng không dây? ", "Công suất truyền tải của bộ phát sóng", new List<string> { "Công suất truyền tải của bộ phát sóng", "Chỉ số RSSI (Received Signal Strength Indication)", "Số lượng thiết bị kết nối", "Độ dài của mật khẩu mạng" } ),
new Question("24. Công nghệ MU-MIMO trong mạng Wi-Fi là gì? ", "Cho phép gửi dữ liệu đến nhiều thiết bị cùng một lúc", new List<string> { "Cho phép gửi dữ liệu đến nhiều thiết bị cùng một lúc", "Một phương pháp mã hóa dữ liệu", "Mở rộng phạm vi sóng Wi-Fi", "Tăng cường bảo mật mạng" } ),
new Question("25. Công nghệ DFS (Dynamic Frequency Selection) trong mạng không dây làm gì? ", "Tìm kênh tần số trống để tránh xung đột", new List<string> { "Tìm kênh tần số trống để tránh xung đột", "Tăng cường bảo mật mạng", "Kiểm tra tín hiệu Wi-Fi xung quanh", "Điều chỉnh công suất truyền dữ liệu" } ),
new Question("26. Chuẩn Wi-Fi nào được coi là có khả năng tiết kiệm năng lượng tốt nhất? ", "802.11ax", new List<string> { "802.11ax", "802.11g", "802.11n", "802.11ac" } ),
new Question("27. Một ưu điểm chính của mạng Wi-Fi 6 (802.11ax) là gì? ", "Tiết kiệm năng lượng hơn", new List<string> { "Tiết kiệm năng lượng hơn", "Tăng tốc độ truyền dữ liệu tối đa", "Hỗ trợ ít thiết bị kết nối hơn", "Giảm độ trễ trong mạng" } ),
new Question("28. Đặc điểm nào quan trọng khi cài đặt một mạng Wi-Fi để đạt hiệu suất tốt nhất? ", "Đặt các điểm truy cập gần nhau", new List<string> { "Đặt các điểm truy cập gần nhau", "Sử dụng chung mật khẩu với các thiết bị khác", "Đặt mật khẩu mạng mạnh", "Sử dụng nhiều kênh tần số khác nhau" } ),
new Question("29. Công nghệ nào cho phép thiết lập một mạng riêng tư và an toàn từ một mạng công cộng? ", "VPN (Virtual Private Network)", new List<string> { "VPN (Virtual Private Network)", "VLAN (Virtual Local Area Network)", "VPS (Virtual Private Server)", "VPC (Virtual Private Cloud)" } ),
new Question("30. Tần số 60GHz được sử dụng trong chuẩn nào sau đây của Wi-Fi? ", "802.11ad", new List<string> { "802.11ad", "802.11ac", "802.11n", "802.11ax" } ),
new Question("31. Trong mạng Wi-Fi, Channel Bonding là gì? ", "Ghép nối nhiều kênh tần số để tăng băng thông", new List<string> { "Ghép nối nhiều kênh tần số để tăng băng thông", "Kết nối giữa các kênh tần số khác nhau", "Ghép nối các điểm truy cập", "Ghép nối các tín hiệu mạng từ nhiều nguồn khác nhau" } ),
new Question("32. Điều gì có thể gây giảm hiệu suất mạng Wi-Fi? ", "Sử dụng tường lớn làm vật cản", new List<string> { "Sử dụng tường lớn làm vật cản", "Sự tiếp xúc với ánh sáng mặt trời", "Sử dụng tường làm vật cản", "Cả ba câu trên" } ),
new Question("33. Trong mạng Wi-Fi, SSID Broadcast có ý nghĩa gì? ", "Tín hiệu truyền phát tên mạng", new List<string> { "Tín hiệu truyền phát tên mạng", "Chế độ không gây nhiễu tín hiệu", "Bảo mật tín hiệu không dây", "Tăng cường tốc độ truyền dữ liệu" } ),
new Question("34. Điều gì phân biệt giữa mạng Wi-Fi công cộng và mạng Wi-Fi cá nhân? ", "Bảo mật", new List<string> { "Bảo mật", "Tốc độ truyền dữ liệu", "Số lượng thiết bị kết nối", "Tên mạng (SSID)" } ),
new Question("35. Mạng Wi-Fi có thể gặp vấn đề Interference do điều gì? ", "Sự can thiệp từ thiết bị điện tử khác", new List<string> { "Sự can thiệp từ thiết bị điện tử khác", "Sự thay đổi địa hình", "Sử dụng mật khẩu mạng không đúng", "Sự thay đổi trong SSID" } ),
new Question("36. Khi một tín hiệu không dây đi qua vật cản, điều gì xảy ra với tín hiệu đó? ", "Suy giảm", new List<string> { "Suy giảm", "Tăng cường", "Không thay đổi", "Biến mất" } ),
new Question("37. Đâu là ưu điểm chính của chuẩn Wi-Fi 6E? ", "Sử dụng băng tần tần số cao hơn", new List<string> { "Sử dụng băng tần tần số cao hơn", "Sự tương thích tốt hơn với các thiết bị cũ", "Tăng tốc độ truyền dữ liệu", "Tiết kiệm năng lượng hơn" } ),
new Question("38. WPS trong mạng Wi-Fi là viết tắt của gì? ", "Wi-Fi Protected Setup", new List<string> { "Wi-Fi Protected Setup", "Wireless Password Security", "Wireless Performance Standard", "Wi-Fi Power Saving" } ),
new Question("39. Điểm truy cập không dây Repeater có chức năng gì trong mạng Wi-Fi? ", "Mở rộng phạm vi sóng", new List<string> { "Mở rộng phạm vi sóng", "Tăng cường bảo mật mạng", "Giảm độ trễ trong mạng", "Chuyển đổi giữa các kênh tần số" } ),
new Question("40. Giao thức nào được sử dụng để xác thực người dùng vào mạng Wi-Fi? ", "EAP", new List<string> { "EAP", "HTTP", "FTP", "WPA2" } ),
new Question("41. Công nghệ Dual-band trong mạng Wi-Fi cho phép gì? ", "Sử dụng hai băng tần tần số khác nhau", new List<string> { "Sử dụng hai băng tần tần số khác nhau", "Sử dụng hai anten trên cùng một thiết bị", "Kết nối đồng thời với hai mạng Wi-Fi khác nhau", "Ghép nối hai điểm truy cập không dây" } ),
new Question("42. Trong mạng Wi-Fi, Latency là gì? ", "Độ trễ trong việc truyền dữ liệu", new List<string> { "Độ trễ trong việc truyền dữ liệu", "Tốc độ truyền dữ liệu tối đa", "Số lượng thiết bị kết nối đồng thời", "Băng thông tối đa của mạng" } ),
new Question("43. Điều gì có thể làm giảm tốc độ mạng Wi-Fi? ", "Sử dụng nhiều thiết bị kết nối cùng lúc", new List<string> { "Sử dụng nhiều thiết bị kết nối cùng lúc", "Sử dụng kết nối cáp thay vì Wi-Fi", "Sử dụng mật khẩu mạng mạnh", "Sử dụng cùng một tần số Wi-Fi với hàng xóm" } ),
new Question("44. DHCP là viết tắt của gì trong mạng Wi-Fi? ", "Dynamic Host Configuration Protocol", new List<string> { "Dynamic Host Configuration Protocol", "Domain Host Control Program", "Data Host Configuration Process", "Direct Host Connection Protocol" } ),
new Question("45. Trong mạng Wi-Fi, Packet Loss là hiện tượng gì? ", "Mất mát dữ liệu trong quá trình truyền", new List<string> { "Mất mát dữ liệu trong quá trình truyền", "Giảm độ trễ mạng", "Tăng tốc độ truyền dữ liệu", "Tăng cường bảo mật mạng" } ),
new Question("46. Một kỹ thuật để tăng cường vùng phủ sóng của mạng Wi-Fi là gì? ", "Mesh networking", new List<string> { "Mesh networking", "Channel bonding", "Beamforming", "Interference avoidance" } ),
new Question("47. Trong mạng Wi-Fi, MAC Filtering dùng để làm gì? ", "Giới hạn các thiết bị được kết nối dựa trên địa chỉ MAC", new List<string> { "Giới hạn các thiết bị được kết nối dựa trên địa chỉ MAC", "Chuyển đổi địa chỉ MAC của thiết bị", "Mã hóa dữ liệu truyền qua mạng", "Tăng cường tốc độ truyền dữ liệu" } ),
new Question("48. Một công nghệ tăng cường tốc độ mạng Wi-Fi là gì? ", "MU-MIMO", new List<string> { "MU-MIMO", "VPN", "VLAN", "WEP" } ),
new Question("49. Giao thức nào được sử dụng để mã hóa dữ liệu trong mạng Wi-Fi? ", "WPA3", new List<string> { "WPA3", "HTTPS", "SSL", "FTPS" } ),
new Question("50. Trong mạng Wi-Fi, QoS viết tắt của cụm từ nào sau đây? ", "Quality of Service", new List<string> { "Quality of Service", "Quick Online Service", "Query of Security", "Quota of Speed" } ),
new Question("51. Chuẩn Wi-Fi nào cung cấp hỗ trợ đa người dùng MU-MIMO (Multi-User, Multiple Input, Multiple Output)? ", "802.11ac", new List<string> { "802.11ac", "802.11n", "802.11g", "802.11b" } ),
new Question("52. Trong mạng Wi-Fi, WMM là gì? ", "Wi-Fi Multimedia", new List<string> { "Wi-Fi Multimedia", "Wi-Fi Management Module", "Wireless Modulation Mode", "Wireless Multipoint Mode" } ),
new Question("53. Điều gì xác định tốc độ kết nối không dây trên mạng Wi-Fi? ", "Độ trễ (Latency)", new List<string> { "Độ trễ (Latency)", "Sức mạnh tín hiệu (Signal Strength)", "Địa chỉ MAC (MAC Address)", "Kiểu mã hóa (Encryption Type)" } ),
new Question("54. Mạng Mesh Wi-Fi chủ yếu giải quyết vấn đề gì? ", "Mở rộng vùng phủ sóng Wi-Fi", new List<string> { "Mở rộng vùng phủ sóng Wi-Fi", "Tăng tốc độ Internet", "Tăng cường bảo mật mạng", "Giảm độ trễ khi truyền dữ liệu" } ),
new Question("55. Trong mạng Wi-Fi, công nghệ WPA3 có ý nghĩa gì? ", "Tăng cường bảo mật mạng", new List<string> { "Tăng cường bảo mật mạng", "Mở rộng phạm vi sóng Wi-Fi", "Tăng tốc độ truyền dữ liệu", "Mở rộng số lượng thiết bị kết nối" } ),
new Question("56. Công nghệ nào trong Wi-Fi được sử dụng để tối ưu hóa định tuyến tín hiệu không dây? ", "Beamforming", new List<string> { "Beamforming", "Mesh Networking", "MU-MIMO", "Channel Bonding" } ),
new Question("57. Trong mạng Wi-Fi, Firmware là gì? ", "Phần mềm nhúng của thiết bị mạng", new List<string> { "Phần mềm nhúng của thiết bị mạng", "Phần mềm quản lý mạng", "Phần mềm của điểm truy cập", "Cấu hình mạng không dây" } ),
new Question("58. Đặc điểm nào được coi là hạn chế của mạng không dây so với mạng có dây (wired network)? ", "Ổn định kém", new List<string> { "Ổn định kém", "Tốc độ truyền dữ liệu thấp hơn", "Bảo mật kém hơn", "Khả năng mở rộng kém" } ),
new Question("59. Chuẩn Wi-Fi nào cho phép kết nối trên băng tần 5GHz? ", "802.11a", new List<string> { "802.11a", "802.11b", "802.11g", "802.11n" } ),
new Question("60. Trong mạng Wi-Fi, WPS (Wi-Fi Protected Setup) được sử dụng để làm gì? ", "Tự động kết nối vào mạng Wi-Fi", new List<string> { "Tự động kết nối vào mạng Wi-Fi", "Tăng cường bảo mật mạng", "Tạo một mạng riêng ảo (VLAN)", "Quản lý địa chỉ IP" } ),
new Question("61. Bluetooth và Wi-Fi khác nhau như thế nào? ", "Bluetooth chạy trên băng tần 2.4GHz, Wi-Fi chạy trên băng tần 5GHz.", new List<string> { "Bluetooth chạy trên băng tần 2.4GHz, Wi-Fi chạy trên băng tần 5GHz.", "Bluetooth chậm hơn Wi-Fi.", "Wi-Fi không dùng để kết nối thiết bị không dây.", "Bluetooth không có bảo mật." } ),
new Question("62. Điểm truy cập không dây Access Point (AP) thường được sử dụng để làm gì? ", "Mở rộng vùng phủ sóng mạng Wi-Fi", new List<string> { "Mở rộng vùng phủ sóng mạng Wi-Fi", "Chuyển đổi giữa các kênh tần số", "Giảm độ trễ khi truyền dữ liệu", "Mã hóa dữ liệu truyền qua mạng" } ),
new Question("63. Trong mạng Wi-Fi, RSSI viết tắt của cụm từ gì? ", "Received Signal Strength Indication", new List<string> { "Received Signal Strength Indication", "Remote Signal Strength Indicator", "Radio Signal Stability Index", "Router Security Status Information" } ),
new Question("64. Trong mạng Wi-Fi, điều gì có thể làm giảm tốc độ truyền dữ liệu? ", "Độ trễ (Latency)", new List<string> { "Độ trễ (Latency)", "Sử dụng kênh tần số rộng", "Sử dụng WPA3", "Tín hiệu mạnh (Strong Signal)" } ),
new Question("65. Chuẩn Wi-Fi nào hiện nay cung cấp tốc độ nhanh nhất? ", "802.11ac", new List<string> { "802.11ac", "802.11n", "802.11g", "802.11b" } ),
new Question("66. Trong mạng Wi-Fi, Bandwidth là gì? ", "Tốc độ truyền dữ liệu tối đa", new List<string> { "Tốc độ truyền dữ liệu tối đa", "Số lượng thiết bị kết nối đồng thời", "Số lượng kênh tần số sử dụng", "Khả năng chịu tải của mạng" } ),
new Question("67. Trong mạng Wi-Fi, SSID viết tắt của cụm từ gì? ", "Service Set Identifier", new List<string> { "Service Set Identifier", "Signal Security Identifier", "System Signal Identifier", "Security System Identifier" } ),
new Question("68. Công nghệ nào trong Wi-Fi giúp tăng cường tín hiệu đến các thiết bị cụ thể? ", "MU-MIMO", new List<string> { "MU-MIMO", "DFS", "WPA3", "VLAN" } ),
new Question("69. MU-MIMO trong Wi-Fi có ý nghĩa gì? ", "Cho phép gửi dữ liệu đến nhiều thiết bị cùng một lúc", new List<string> { "Cho phép gửi dữ liệu đến nhiều thiết bị cùng một lúc", "Mở rộng phạm vi sóng Wi-Fi", "Tăng cường bảo mật mạng", "Tăng tốc độ truyền dữ liệu" } ),
new Question("70. Chuẩn Wi-Fi nào có khả năng hoạt động trên cả băng tần 2.4GHz và 5GHz? ", "802.11n", new List<string> { "802.11n", "802.11g", "802.11ac", "802.11ax" } ),
new Question("71. Trong mạng Wi-Fi, 802.11ax được biết đến với tên gọi thương mại là gì? ", "Wi-Fi 6", new List<string> { "Wi-Fi 6", "Wi-Fi 4", "Wi-Fi 5", "Wi-Fi 7" } ),
new Question("72. NFC trong mạng không dây là viết tắt của gì? ", "Near Field Connection", new List<string> { "Near Field Connection", "Network Frequency Control", "Non-Frequency Communication", "Network Field Connectivity" } ),
new Question("73. Trong mạng Wi-Fi, giao thức DHCP làm gì? ", "Quản lý địa chỉ IP tự động cho thiết bị kết nối", new List<string> { "Quản lý địa chỉ IP tự động cho thiết bị kết nối", "Xác thực người dùng vào mạng", "Gửi dữ liệu qua mạng", "Mã hóa dữ liệu truyền qua mạng" } ),
new Question("74. Trong mạng Wi-Fi, 802.11X được sử dụng để làm gì? ", "Xác thực người dùng vào mạng", new List<string> { "Xác thực người dùng vào mạng", "Tăng cường bảo mật mạng", "Chuyển đổi giữa các kênh tần số", "Mở rộng phạm vi sóng Wi-Fi" } ),
new Question("75. PoE (Power over Ethernet) trong mạng Wi-Fi có tác dụng gì? ", "Cung cấp nguồn điện cho thiết bị mạng qua cáp Ethernet", new List<string> { "Cung cấp nguồn điện cho thiết bị mạng qua cáp Ethernet", "Tăng cường tốc độ truyền dữ liệu", "Mở rộng phạm vi sóng Wi-Fi", "Tăng cường bảo mật mạng" } ),
new Question("76. Trong mạng Wi-Fi, công nghệ OFDM (Orthogonal Frequency Division Multiplexing) được sử dụng để làm gì? ", "Tăng cường tốc độ truyền dữ liệu", new List<string> { "Tăng cường tốc độ truyền dữ liệu", "Tạo ra kết nối VPN", "Mã hóa dữ liệu", "Chuyển đổi giữa các kênh tần số" } ),
new Question("77. 802.11r trong Wi-Fi liên quan đến điều gì? ", "Roaming nhanh hơn giữa các điểm truy cập", new List<string> { "Roaming nhanh hơn giữa các điểm truy cập", "Quản lý địa chỉ IP tự động", "Tăng cường bảo mật mạng", "Tăng tốc độ truyền dữ liệu" } ),
new Question("78. Trong mạng Wi-Fi, STBC (Space-Time Block Coding) được sử dụng để làm gì? ", "Tăng cường tín hiệu", new List<string> { "Tăng cường tín hiệu", "Mã hóa dữ liệu", "Tăng cường bảo mật mạng", "Tăng cường tốc độ truyền dữ liệu" } ),
new Question("79. Chuẩn Wi-Fi nào được coi là đẳng cấp nhất hiện nay? ", "802.11ad", new List<string> { "802.11ad", "802.11n", "802.11ac", "802.11ax" } ),
new Question("80. Công nghệ nào cho phép việc chuyển dữ liệu giữa các thiết bị một cách nhanh chóng thông qua chạm hoặc gần nhau? ", "NFC", new List<string> { "NFC", "Bluetooth", "Wi-Fi Direct", "Infrared" } )
                // Add more questions here
            };

            random = new Random();
            btnRemoveNumbers.Click += btnRemoveNumbers_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayRandomQuestion();
            
        }

        private void DisplayRandomQuestion()
        {
            if (questions.Count > 0)
            {
                int index = random.Next(questions.Count);
                currentQuestion = questions[index];

                // Display the question
                lblQuestion.Text = currentQuestion.Text;
                lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
                btnChoice1.Text = currentQuestion.Choices[0];
                btnChoice2.Text = currentQuestion.Choices[1];
                btnChoice3.Text = currentQuestion.Choices[2];
                btnChoice4.Text = currentQuestion.Choices[3];

                // Randomize the choices
                List<string> randomizedChoices = currentQuestion.Choices.OrderBy(x => random.Next()).ToList();
                btnChoice1.Text = randomizedChoices[0];
                btnChoice2.Text = randomizedChoices[1];
                btnChoice3.Text = randomizedChoices[2];
                btnChoice4.Text = randomizedChoices[3];

                // Reset button colors
                ResetButtonColors();
            }
            else
            {
                // No more questions, end the quiz
                MessageBox.Show("Kết thúc rồi! Không lưu điểm quá trình đâu, các bạn thi lại nha!");
                Close();
            }
        }

        private void ResetButtonColors()
        {
            btnChoice1.BackColor = SystemColors.Control;
            btnChoice2.BackColor = SystemColors.Control;
            btnChoice3.BackColor = SystemColors.Control;
            btnChoice4.BackColor = SystemColors.Control;
        }

        private void CheckAnswer(Button selectedButton)
        {
            if (selectedButton.Text.Equals(currentQuestion.Answer, StringComparison.OrdinalIgnoreCase))
            {
                selectedButton.BackColor = Color.Green;
                MessageBox.Show("Đúng rồi! Qua môn!", "Đúng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                selectedButton.BackColor = Color.Red;
                MessageBox.Show("Sai rôi! Rớt môn nha!", "Sai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Remove the current question from the list
            questions.Remove(currentQuestion);

            // Display the next random question
            DisplayRandomQuestion();
        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice1);
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice2);
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice3);
        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice4);
        }

        public class Question
        {
            public string Text { get; set; }
            public string Answer { get; set; }
            public List<string> Choices { get; set; }

            public Question(string text, string answer, List<string> choices)
            {
                Text = text;
                Answer = answer;
                Choices = choices;
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveNumbers_Click(object sender, EventArgs e)
        {
            List<string> prefixes = new List<string> { "1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "9.", "10.", "11.", "12.", "13.", "14.", "15.", "16.", "17.", "18.", "19.", "20.", "21.", "22.", "23.", "24.", "25.", "26.", "27.", "28.", "29.", "30.", "31.", "32.", "33.", "34.", "35.", "36.", "37.", "38.", "39.", "40.", "41.", "42.", "43.", "44.", "45.", "46.", "47.", "48.", "49.", "50.", "51.", "52.", "53.", "54.", "55.", "56.", "57.", "58.", "59.", "60.", "61.", "62.", "63.", "64.", "65.", "66.", "67.", "68.", "69.", "70.", "71.", "72.", "73.", "74.", "75.", "76.", "77.", "78.", "79.", "80." };

            // Loop through each question and remove the numbering
            foreach (var question in questions)
            {
                // Check if the question text starts with a number and a dot
                if (prefixes.Any(prefix => question.Text.StartsWith(prefix)))
                {
                    // Remove the number and dot from the beginning of the question text
                    question.Text = question.Text.Substring(question.Text.IndexOf(' ') + 1);
                }
            }

            // Update the display with the modified questions
            DisplayRandomQuestion();
            btnRemoveNumbers.Hide();
        }
    }
}
