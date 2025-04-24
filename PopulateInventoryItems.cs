// PopulateInventoryItems.cs
// Description: This file contains a class that populates the inventory with sample items.
using System;

namespace InventoryManagementSystem
{
    public class PopulateInitialInventoryClass
    {
        public static void PopulateInventoryItems(Dictionary<int, InventoryItem> inventoryItems)
            {
                // This method populates the inventory with some sample items.
                // It takes a dictionary of inventory items as a parameter.
                
            inventoryItems.Add(1, new InventoryItem("XPS 13", "Dell", "High-performance 13-inch laptop for professionals.", 10, 999.99m, "Laptop"));
            inventoryItems.Add(2, new InventoryItem("iPhone 14", "Apple", "Latest smartphone with advanced features and a powerful camera.", 20, 799.99m, "Smartphone"));
            inventoryItems.Add(3, new InventoryItem("WH-1000XM4", "Sony", "Wireless noise-cancelling headphones with superior sound.", 15, 349.99m, "Headphones"));
            inventoryItems.Add(4, new InventoryItem("Watch Series 7", "Apple", "Smartwatch with fitness tracking and health monitoring.", 5, 399.99m, "Smartwatch"));
            inventoryItems.Add(5, new InventoryItem("Galaxy Tab S7", "Samsung", "Android tablet for productivity and entertainment.", 8, 649.99m, "Tablet"));
            inventoryItems.Add(6, new InventoryItem("UltraFine 5K", "LG", "27-inch monitor with 5K resolution for creative professionals.", 12, 1299.99m, "Monitor"));
            inventoryItems.Add(7, new InventoryItem("MX Keys", "Logitech", "Wireless keyboard with a comfortable typing experience.", 25, 99.99m, "Keyboard"));
            inventoryItems.Add(8, new InventoryItem("MX Master 3", "Logitech", "Advanced wireless mouse for precise control.", 30, 99.99m, "Mouse"));
            inventoryItems.Add(9, new InventoryItem("LaserJet Pro", "HP", "Monochrome laser printer for office use.", 7, 199.99m, "Printer"));
            inventoryItems.Add(10, new InventoryItem("Nighthawk", "Netgear", "Dual-band Wi-Fi router for fast internet speeds.", 12, 149.99m, "Router"));
            inventoryItems.Add(11, new InventoryItem("Backup Plus", "Seagate", "2TB external hard drive for data storage.", 20, 89.99m, "External Hard Drive"));
            inventoryItems.Add(12, new InventoryItem("Cruzer", "SanDisk", "64GB USB flash drive for portable storage.", 50, 19.99m, "USB Flash Drive"));
            inventoryItems.Add(13, new InventoryItem("C920", "Logitech", "Full HD webcam for video conferencing.", 10, 79.99m, "Webcam"));
            inventoryItems.Add(14, new InventoryItem("Yeti", "Blue", "USB microphone for podcasting and streaming.", 8, 129.99m, "Microphone"));
            inventoryItems.Add(15, new InventoryItem("GeForce RTX 3080", "NVIDIA", "High-performance graphics card for gaming.", 3, 699.99m, "Graphics Card"));
            inventoryItems.Add(16, new InventoryItem("ROG Strix", "ASUS", "Gaming motherboard for high-end builds.", 5, 249.99m, "Motherboard"));
            inventoryItems.Add(17, new InventoryItem("RM850x", "Corsair", "850W power supply for reliable power.", 10, 129.99m, "Power Supply"));
            inventoryItems.Add(18, new InventoryItem("Core i9-11900K", "Intel", "High-end desktop processor for gaming and content creation.", 4, 499.99m, "CPU"));
            inventoryItems.Add(19, new InventoryItem("Vengeance LPX 32GB", "Corsair", "32GB DDR4 RAM kit for desktop computers.", 15, 159.99m, "RAM"));
            inventoryItems.Add(20, new InventoryItem("970 EVO Plus 1TB", "Samsung", "1TB NVMe SSD for fast storage.", 10, 149.99m, "SSD"));
            inventoryItems.Add(21, new InventoryItem("MacBook Air M2", "Apple", "Lightweight laptop with Apple M2 chip.", 15, 1199.99m, "Laptop"));
            inventoryItems.Add(22, new InventoryItem("Spectre x360", "HP", "Convertible laptop with a 360-degree hinge.", 8, 1399.99m, "Laptop"));
            inventoryItems.Add(23, new InventoryItem("ThinkPad X1 Carbon", "Lenovo", "Premium ultrabook for business professionals.", 12, 1599.99m, "Laptop"));
            inventoryItems.Add(24, new InventoryItem("Galaxy S23", "Samsung", "Flagship Android smartphone with a pro-grade camera.", 25, 899.99m, "Smartphone"));
            inventoryItems.Add(25, new InventoryItem("Pixel 7", "Google", "Smartphone with a user-friendly experience and great camera.", 18, 699.99m, "Smartphone"));
            inventoryItems.Add(26, new InventoryItem("13 Pro", "Xiaomi", "Smartphone with a focus on camera technology.", 10, 749.99m, "Smartphone"));
            inventoryItems.Add(27, new InventoryItem("QuietComfort 45", "Bose", "Wireless noise-cancelling headphones for travel.", 20, 329.99m, "Headphones"));
            inventoryItems.Add(28, new InventoryItem("HD 660S", "Sennheiser", "Open-back headphones for critical listening.", 7, 499.99m, "Headphones"));
            inventoryItems.Add(29, new InventoryItem("AirPods Max", "Apple", "Over-ear headphones with high-fidelity audio.", 10, 549.99m, "Headphones"));
            inventoryItems.Add(30, new InventoryItem("Galaxy Watch 5", "Samsung", "Smartwatch with health and fitness tracking.", 12, 349.99m, "Smartwatch"));
            inventoryItems.Add(31, new InventoryItem("Forerunner 955", "Garmin", "GPS smartwatch for runners and triathletes.", 6, 499.99m, "Smartwatch"));
            inventoryItems.Add(32, new InventoryItem("Sense 2", "Fitbit", "Advanced health smartwatch with stress management.", 15, 299.99m, "Smartwatch"));
            inventoryItems.Add(33, new InventoryItem("iPad Pro 11-inch", "Apple", "Powerful tablet for creative work and productivity.", 10, 799.99m, "Tablet"));
            inventoryItems.Add(34, new InventoryItem("Surface Pro 9", "Microsoft", "2-in-1 tablet with laptop functionality.", 7, 999.99m, "Tablet"));
            inventoryItems.Add(35, new InventoryItem("Fire HD 10", "Amazon", "Affordable tablet for entertainment and everyday use.", 30, 149.99m, "Tablet"));
            inventoryItems.Add(36, new InventoryItem("UltraSharp U2723QE", "Dell", "27-inch 4K monitor with excellent color accuracy.", 8, 599.99m, "Monitor"));
            inventoryItems.Add(37, new InventoryItem("Odyssey G9", "Samsung", "49-inch ultrawide curved gaming monitor.", 4, 1499.99m, "Monitor"));
            inventoryItems.Add(38, new InventoryItem("EX2710U", "BenQ", "27-inch 4K gaming monitor with 144Hz refresh rate.", 11, 799.99m, "Monitor"));
            inventoryItems.Add(39, new InventoryItem("K95 RGB Platinum", "Corsair", "Mechanical gaming keyboard with customizable RGB lighting.", 15, 199.99m, "Keyboard"));
            inventoryItems.Add(40, new InventoryItem("K2 Pro", "Keychron", "Compact wireless mechanical keyboard.", 20, 139.99m, "Keyboard"));
            inventoryItems.Add(41, new InventoryItem("BlackWidow V3", "Razer", "Mechanical keyboard with Razer Chroma RGB lighting.", 18, 159.99m, "Keyboard"));
            inventoryItems.Add(42, new InventoryItem("Basilisk V3", "Razer", "Customizable ergonomic gaming mouse.", 22, 69.99m, "Mouse"));
            inventoryItems.Add(43, new InventoryItem("Aerox 5 Wireless", "SteelSeries", "Lightweight multi-genre wireless gaming mouse.", 14, 129.99m, "Mouse"));
            inventoryItems.Add(44, new InventoryItem("Magic Mouse", "Apple", "Wireless mouse with Multi-Touch surface.", 28, 79.99m, "Mouse"));
            inventoryItems.Add(45, new InventoryItem("EcoTank ET-3830", "Epson", "Wireless all-in-one printer with refillable ink tanks.", 9, 299.99m, "Printer"));
            inventoryItems.Add(46, new InventoryItem("Pixma MG3620", "Canon", "Wireless all-in-one inkjet printer.", 16, 79.99m, "Printer"));
            inventoryItems.Add(47, new InventoryItem("Archer AX50", "TP-Link", "AX3000 Wi-Fi 6 router for high-speed internet.", 15, 99.99m, "Router"));
            inventoryItems.Add(48, new InventoryItem("Nest Wifi", "Google", "Mesh Wi-Fi system for whole-home coverage.", 7, 199.99m, "Router"));
            inventoryItems.Add(49, new InventoryItem("My Passport", "Western Digital", "4TB portable external hard drive for on-the-go storage.", 25, 79.99m, "External Hard Drive"));
            inventoryItems.Add(50, new InventoryItem("Canvio Basics", "Toshiba", "2TB portable external hard drive for simple storage.", 30, 69.99m, "External Hard Drive"));
            inventoryItems.Add(51, new InventoryItem("DataTraveler", "Kingston", "128GB USB 3.2 Gen 1 flash drive for fast data transfer.", 60, 14.99m, "USB Flash Drive"));
            inventoryItems.Add(52, new InventoryItem("BAR Plus", "Samsung", "128GB USB 3.1 metal flash drive for durability.", 40, 24.99m, "USB Flash Drive"));
            inventoryItems.Add(53, new InventoryItem("Tiny 2", "OBSBOT", "4K webcam with AI tracking and auto-framing.", 5, 199.99m, "Webcam"));
            inventoryItems.Add(54, new InventoryItem("PowerConf C300", "Anker", "Smart 1080p webcam with AI-enhanced clarity.", 12, 99.99m, "Webcam"));
            inventoryItems.Add(55, new InventoryItem("NT-USB Mini", "Rode", "USB microphone for content creators and streamers.", 10, 99.99m, "Microphone"));
            inventoryItems.Add(56, new InventoryItem("SM58", "Shure", "Industry-standard dynamic microphone for vocals.", 3, 99.00m, "Microphone"));
            inventoryItems.Add(57, new InventoryItem("Radeon RX 7900 XTX", "AMD", "High-end graphics card for 4K gaming.", 2, 999.99m, "Graphics Card"));
            inventoryItems.Add(58, new InventoryItem("Arc A770", "Intel", "Graphics card with Xe HPG architecture.", 7, 349.99m, "Graphics Card"));
            inventoryItems.Add(59, new InventoryItem("MAG B650 Tomahawk WIFI", "MSI", "AMD B650 motherboard with Wi-Fi 6E support.", 6, 219.99m, "Motherboard"));
            inventoryItems.Add(60, new InventoryItem("Z790 AORUS Elite AX", "Gigabyte", "Intel Z790 motherboard with advanced features.", 4, 299.99m, "Motherboard"));
            inventoryItems.Add(61, new InventoryItem("FOCUS GX-750", "Seasonic", "750W 80+ Gold certified power supply.", 12, 119.99m, "Power Supply"));
            inventoryItems.Add(62, new InventoryItem("SuperNOVA 850 GT", "EVGA", "850W 80+ Gold certified power supply.", 9, 139.99m, "Power Supply"));
            inventoryItems.Add(63, new InventoryItem("Ryzen 9 7950X3D", "AMD", "High-performance desktop processor with 3D V-Cache.", 3, 699.99m, "CPU"));
            inventoryItems.Add(64, new InventoryItem("Core i7-13700K", "Intel", "High-performance desktop processor for enthusiasts.", 5, 409.99m, "CPU"));
            inventoryItems.Add(65, new InventoryItem("Trident Z5 Neo 32GB", "G.Skill", "32GB DDR5 memory kit optimized for AMD Ryzen.", 18, 179.99m, "RAM"));
            inventoryItems.Add(66, new InventoryItem("Ballistix 16GB", "Crucial", "16GB DDR4 memory kit for gaming.", 25, 79.99m, "RAM"));
            inventoryItems.Add(67, new InventoryItem("P5 Plus 2TB", "Crucial", "2TB PCIe 4.0 NVMe SSD for high-speed storage.", 8, 199.99m, "SSD"));
            inventoryItems.Add(68, new InventoryItem("Black SN850X 2TB", "Western Digital", "2TB PCIe Gen4 NVMe SSD for gaming and content creation.", 6, 229.99m, "SSD"));
            inventoryItems.Add(69, new InventoryItem("G Pro X Superlight", "Logitech", "Ultra-lightweight wireless gaming mouse for esports.", 15, 149.99m, "Gaming Mouse"));
            inventoryItems.Add(70, new InventoryItem("Alloy Origins 60", "HyperX", "60% mechanical gaming keyboard with RGB lighting.", 12, 109.99m, "Gaming Keyboard"));
            inventoryItems.Add(71, new InventoryItem("Surface Laptop 5", "Microsoft", "Slim and stylish laptop with a touchscreen display.", 10, 1299.99m, "Laptop"));
            inventoryItems.Add(72, new InventoryItem("Zenbook S 13 OLED", "ASUS", "Ultra-thin laptop with a vibrant OLED display.", 7, 1499.99m, "Laptop"));
            inventoryItems.Add(73, new InventoryItem("11", "OnePlus", "Flagship smartphone with a powerful processor.", 20, 799.99m, "Smartphone"));
            inventoryItems.Add(74, new InventoryItem("Edge 40 Pro", "Motorola", "Smartphone with a high refresh rate display.", 15, 849.99m, "Smartphone"));
            inventoryItems.Add(75, new InventoryItem("WF-1000XM5", "Sony", "Compact wireless earbuds with noise cancellation.", 18, 299.99m, "Headphones"));
            inventoryItems.Add(76, new InventoryItem("PX7 S2e", "Bowers & Wilkins", "Wireless headphones with high-quality audio.", 9, 399.99m, "Headphones"));
            inventoryItems.Add(77, new InventoryItem("Pixel Watch 2", "Google", "Smartwatch with Wear OS and Google integration.", 11, 349.99m, "Smartwatch"));
            inventoryItems.Add(78, new InventoryItem("Watch GT 3 Pro", "Huawei", "Smartwatch with a premium design and long battery life.", 6, 329.99m, "Smartwatch"));
            inventoryItems.Add(79, new InventoryItem("Tab P11 Pro Gen 2", "Lenovo", "Tablet with an OLED display and stylus support.", 8, 499.99m, "Tablet"));
            inventoryItems.Add(80, new InventoryItem("Pad 6 Pro", "Xiaomi", "Tablet with a large display and powerful performance.", 12, 449.99m, "Tablet"));
            inventoryItems.Add(81, new InventoryItem("34GN850-B UltraGear", "LG", "34-inch ultrawide gaming monitor with Nano IPS.", 5, 799.99m, "Monitor"));
            inventoryItems.Add(82, new InventoryItem("ViewFinity S8", "Samsung", "32-inch high-resolution monitor for professionals.", 10, 499.99m, "Monitor"));
            inventoryItems.Add(83, new InventoryItem("G915 Lightspeed", "Logitech", "Low-profile wireless mechanical gaming keyboard.", 13, 229.99m, "Keyboard"));
            inventoryItems.Add(84, new InventoryItem("Halo75", "Nuphy", "Wireless mechanical keyboard with customizable RGB.", 16, 169.99m, "Keyboard"));
            inventoryItems.Add(85, new InventoryItem("G502 X Plus", "Logitech", "Wireless gaming mouse with Hero 25K sensor.", 19, 99.99m, "Mouse"));
            inventoryItems.Add(86, new InventoryItem("Scimitar Elite Wireless", "Corsair", "Wireless MMO gaming mouse with 17 programmable buttons.", 10, 129.99m, "Mouse"));
            inventoryItems.Add(87, new InventoryItem("HL-L2350DW", "Brother", "Compact monochrome laser printer with wireless printing.", 14, 119.99m, "Printer"));
            inventoryItems.Add(88, new InventoryItem("Envy 6055e", "HP", "Wireless color all-in-one printer for home use.", 22, 99.99m, "Printer"));
            inventoryItems.Add(89, new InventoryItem("RT-AX82U", "ASUS", "AX5400 dual-band Wi-Fi 6 gaming router.", 8, 199.99m, "Router"));
            inventoryItems.Add(90, new InventoryItem("Velop Mesh WiFi System", "Linksys", "Tri-band mesh Wi-Fi system for seamless coverage.", 7, 249.99m, "Router"));
            inventoryItems.Add(91, new InventoryItem("Expansion Portable", "Seagate", "4TB portable external hard drive for simple backup.", 35, 59.99m, "External Hard Drive"));
            inventoryItems.Add(92, new InventoryItem("Elements Portable", "WD", "5TB portable external hard drive for reliable storage.", 40, 54.99m, "External Hard Drive"));
            inventoryItems.Add(93, new InventoryItem("JetFlash 930", "Transcend", "256GB USB 3.2 Gen 1 flash drive for high-speed transfers.", 28, 34.99m, "USB Flash Drive"));
            inventoryItems.Add(94, new InventoryItem("JumpDrive P30", "Lexar", "128GB USB 3.2 flash drive with fast performance.", 32, 29.99m, "USB Flash Drive"));
            inventoryItems.Add(95, new InventoryItem("Kiyo Pro", "Razer", "Streaming webcam with adaptive light sensor.", 7, 149.99m, "Webcam"));
            inventoryItems.Add(96, new InventoryItem("StreamCam", "Logitech", "Webcam for live streaming and content creation.", 9, 169.99m, "Webcam"));
            inventoryItems.Add(97, new InventoryItem("AT2020", "Audio-Technica", "Cardioid condenser microphone for studio recording.", 5, 99.00m, "Microphone"));
            inventoryItems.Add(98, new InventoryItem("Snowball ICE", "Blue", "USB condenser microphone for recording and streaming.", 12, 49.99m, "Microphone"));
            inventoryItems.Add(99, new InventoryItem("GeForce RTX 4070 Ti", "NVIDIA", "High-performance graphics card for gaming and ray tracing.", 3, 799.99m, "Graphics Card"));
            inventoryItems.Add(100, new InventoryItem("Radeon RX 7800 XT", "AMD", "Graphics card for high-refresh-rate gaming.", 6, 499.99m, "Graphics Card"));
                // Add sample items to the inventory
            }
    }
}