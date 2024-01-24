using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharpCountriesProg.Migrations
{
    /// <inheritdoc />
    public partial class Countries_SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Capital", "Currency", "Name", "PopulationMln", "President", "SurfaceAreaKm2" },
                values: new object[,]
                {
                    { "1", "Kabul", "Afghani", "Afghanistan", 38f, "Ashraf Ghani", 652230 },
                    { "2", "Tirana (Tirane)", "Lek", "Albania", 2.87f, "Ilir Meta", 28748 },
                    { "3", "Algiers", "Algerian Dinar", "Algeria", 44.6f, "Abdelmadjid Tebboune", 2381741 },
                    { "4", "Andorra la Vella", "Euro", "Andorra", 0.08f, "Joan Enric Vives SicÃ­lia", 468 },
                    { "5", "Luanda", "Angolan Kwanza", "Angola", 32.9f, "JoÃ£o LourenÃ§o", 1246700 },
                    { "6", "Saint John's", "East Caribbean Dollar", "Antigua and Barbuda", 0.1f, "Gaston Browne", 442 },
                    { "7", "Buenos Aires", "Argentine Peso", "Argentina", 45.4f, "Alberto FernÃ¡ndez", 2780400 },
                    { "8", "Yerevan", "Armenian Dram", "Armenia", 2.96f, "Armen Sarkissian", 29743 },
                    { "9", "Canberra", "Australian Dollar", "Australia", 25.9f, "Scott Morrison", 7692024 },
                    { "10", "Vienna", "Euro", "Austria", 8.9f, "Alexander Van der Bellen", 83879 },
                    { "11", "Baku", "Azerbaijani Manat", "Azerbaijan", 10.2f, "Ilham Aliyev", 86600 },
                    { "12", "Nassau", "Bahamian Dollar", "Bahamas", 0.39f, "Hubert Minnis", 13880 },
                    { "13", "Manama", "Bahraini Dinar", "Bahrain", 1.7f, "Hamad bin Isa Al Khalifa", 760 },
                    { "14", "Dhaka", "Bangladeshi Taka", "Bangladesh", 165.7f, "Abdul Hamid", 147570 },
                    { "15", "Bridgetown", "Barbadian Dollar", "Barbados", 0.29f, "Mia Mottley", 430 },
                    { "16", "Minsk", "Belarusian Ruble", "Belarus", 9.4f, "Alyaksandr Lukashenka", 207600 },
                    { "17", "Brussels", "Euro", "Belgium", 11.5f, "Alexander De Croo", 30528 },
                    { "18", "Belmopan", "Belize Dollar", "Belize", 0.4f, "Johnny BriceÃ±o", 22966 },
                    { "19", "Porto Novo", "West African CFA franc", "Benin", 12.1f, "Patrice Talon", 112622 },
                    { "20", "Thimphu", "Bhutanese Ngultrum", "Bhutan", 0.8f, "Jigme Khesar Namgyel Wangchuck", 38394 },
                    { "21", "La Paz", "Boliviano", "Bolivia", 11.4f, "Luis Arce", 1098581 },
                    { "22", "Sarajevo", "Bosnia and Herzegovina Convertible Mark", "Bosnia and Herzegovina", 3.3f, "Å efik DÅ¾aferoviÄ‡", 51197 },
                    { "23", "Gaborone", "Botswana Pula", "Botswana", 2.4f, "Mokgweetsi Masisi", 581730 },
                    { "24", "Brasilia", "Brazilian Real", "Brazil", 212.6f, "Jair Bolsonaro", 8515767 },
                    { "25", "Bandar Seri Begawan", "Brunei Dollar", "Brunei", 0.4f, "Hassanal Bolkiah", 5765 },
                    { "26", "Sofia", "Bulgarian Lev", "Bulgaria", 6.9f, "Rumen Radev", 110879 },
                    { "27", "Ouagadougou", "West African CFA franc", "Burkina Faso", 20.3f, "Roch Marc Christian KaborÃ©", 274200 },
                    { "28", "Gitega", "Burundian Franc", "Burundi", 11.5f, "Evariste Ndayishimiye", 27834 },
                    { "29", "Phnom Penh", "Cambodian Riel", "Cambodia", 16.5f, "King Norodom Sihamoni", 181035 },
                    { "30", "Yaounde", "Central African CFA franc", "Cameroon", 26.5f, "Paul Biya", 475442 },
                    { "31", "Ottawa", "Canadian Dollar", "Canada", 38.4f, "Justin Trudeau", 9976140 },
                    { "32", "Praia", "Cape Verdean Escudo", "Cape Verde", 0.5f, "Jorge Carlos Fonseca", 4033 },
                    { "33", "Bangui", "Central African CFA franc", "Central African Republic", 4.7f, "Catherine Samba-Panza", 622984 },
                    { "34", "N'Djamena", " Central African CFA franc", "Chad", 16.4f, "Idriss DÃ©by", 1284000 },
                    { "35", "Santiago", "Chilean Peso", "Chile", 19.2f, "SebastiÃ¡n PiÃ±era", 756102 },
                    { "36", "Beijing", "Chinese Yuan", "China", 1444f, "Xi Jinping", 9596960 },
                    { "37", "Bogota", "Colombian Peso", "Colombia", 50.9f, "IvÃ¡n Duque", 1141748 },
                    { "38", "Moroni", "Comorian Franc", "Comoros", 0.9f, "Azali Assoumani", 1861 },
                    { "39", "San Jose", "Costa Rican ColÃ³n", "Costa Rica", 5.1f, "Carlos Alvarado Quesada", 51100 },
                    { "40", "Zagreb", "Croatian Kuna", "Croatia", 4.1f, "Zoran MilanoviÄ‡", 56594 },
                    { "41", "Havana", "Cuban Peso", "Cuba", 11.2f, "Miguel DÃ­az-Canel", 109884 },
                    { "42", "Nicosia", "Euro", "Cyprus", 1.2f, "Nicos Anastasiades", 9251 },
                    { "43", "Prague", "Czech Koruna", "Czech Republic (Czechia)", 10.7f, "MiloÅ¡ Zeman", 78867 },
                    { "44", "Copenhagen", "Danish Krone", "Denmark", 5.8f, "Mette Frederiksen", 42433 },
                    { "45", "Djibouti", "Djiboutian Franc", "Djibouti", 1f, "Ismail Omar Guelleh", 23000 },
                    { "46", "Roseau", "East Caribbean Dollar", "Dominica", 0.1f, "Charles Savarin", 751 },
                    { "47", "Santo Domingo", "Dominican Peso", "Dominican Republic", 10.8f, "Luis Abinader", 48671 },
                    { "48", "Dili", "United States Dollar", "East Timor", 1.3f, "Francisco Guterres", 14874 },
                    { "49", "Quito", "United States Dollar", "Ecuador", 17.1f, "LenÃ­n Moreno", 276841 },
                    { "50", "Cairo", "Egyptian Pound", "Egypt", 101.7f, "Abdel Fattah el-Sisi", 1002450 },
                    { "51", "San Salvador", "United States Dollar", "El Salvador", 6.5f, "Nayib Bukele", 21041 },
                    { "52", "London", "British Pound", "England", 56.3f, "Queen Elizabeth II", 130395 },
                    { "53", "Malabo", " Central African CFA franc", "Equatorial Guinea", 1.4f, "Teodoro Obiang Nguema Mbasogo", 28051 },
                    { "54", "Asmara", "Eritrean Nakfa", "Eritrea", 3.6f, "Isaias Afwerki", 117600 },
                    { "55", "Tallinn", "Euro", "Estonia", 1.3f, "Kersti Kaljulaid", 45339 },
                    { "56", "Mbabane", "Lilangeni", "Eswatini (Swaziland)", 1.1f, "Mswati III", 17364 },
                    { "57", "Addis Ababa", "Ethiopian Birr", "Ethiopia", 118.4f, "Sahle-Work Zewde", 1104300 },
                    { "58", "Palikir", "United States Dollar", "Federated States of Micronesia", 0.1f, "David W. Panuelo", 702 },
                    { "59", "Suva", "Fijian Dollar", "Fiji", 0.9f, "Jioji Konrote", 18274 },
                    { "60", "Helsinki", "Euro", "Finland", 5.5f, "Sauli Vainamo NiinistÃ", 338145 },
                    { "61", "Paris", "Euro", "France", 67.1f, "Emmanuel Macron", 551695 },
                    { "62", "Libreville", "Central African CFA franc", "Gabon", 2.2f, "Ali Bongo Ondimba", 267667 },
                    { "63", "Banjul", "Gambian Dalasi", "Gambia", 2.4f, "Adama Barrow", 10689 },
                    { "64", "Tbilisi", "Georgian Lari", "Georgia", 3.7f, "Salome Zurabishvili", 69700 },
                    { "65", "Berlin", "Euro", "Germany", 83.2f, "Frank-Walter Steinmeier", 357022 },
                    { "66", "Accra", "Ghanaian Cedi", "Ghana", 31.4f, "Nana Akufo-Addo", 238535 },
                    { "67", "Athens", "Euro", "Greece", 10.4f, "Katerina Sakellaropoulou", 131957 },
                    { "68", "Saint George's", "East Caribbean Dollar", "Grenada", 0.1f, "Charles Angelo Savarin", 344 },
                    { "69", "Guate mala City", "Guatemalan Quetzal", "Guatemala", 17.8f, "Alejandro Giammattei", 108889 },
                    { "70", "Conakry", "Guinean Franc", "Guinea", 12.4f, "Alpha CondÃ©", 245857 },
                    { "71", "Bissau", "West African CFA franc", "Guinea-Bissau", 2f, "Umaro Sissoco EmbalÃ³", 36125 },
                    { "72", "Georgetown", "Guyanese Dollar", "Guyana", 0.8f, "irfaan Ali", 214969 },
                    { "73", "Port-au-Prince", "Haitian Gourde", "Haiti", 11.4f, "Jovenel MoÃ¯se", 27750 },
                    { "74", "Tegucigalpa", "Honduran Lempira", "Honduras", 10.2f, "Juan Orlando HernÃ¡ndez", 112492 },
                    { "75", "Budapest", "Hungarian Forint", "Hungary", 9.7f, "JÃ¡nos Ãder", 93028 },
                    { "76", "Reykjavik", "Icelandic KrÃ³na", "Iceland", 0.4f, "Gudni Thorlacius Johannesson", 103000 },
                    { "77", "New Delhi", "Indian Rupee", "India", 1393f, "Ram Nath Kovind", 3287263 },
                    { "78", "Jakarta", "Indonesian Rupiah", "Indonesia", 276.4f, "Joko Widodo", 1904569 },
                    { "79", "Tehran", "Iranian Rial", "Iran", 83.9f, "Hassan Rouhani", 1648195 },
                    { "80", "Baghdad", "Iraqi Dinar", "Iraq", 39.3f, "Barham Salih", 438317 },
                    { "81", "Dublin", "Euro", "Ireland", 4.9f, "Michael D. Higgins", 70273 },
                    { "82", "Jerusalem", "Israeli New Shekel", "Israel", 9.2f, "Reuven Rivlin", 20770 },
                    { "83", "Rome", "Euro", "Italy", 60.3f, "Sergio Mattarella", 301340 },
                    { "84", "Kingston", "Jamaican Dollar", "Jamaica", 2.9f, "Andrew Holness", 10991 },
                    { "85", "Tokyo", "Japanese Yen", "Japan", 126f, "Naruhito", 377975 },
                    { "86", "Amman", "Jordanian Dinar", "Jordan", 10.1f, "Abdullah II bin Al-Hussein", 89342 },
                    { "87", "Nur-Sultan", "Kazakhstani Tenge", "Kazakhstan", 18.8f, "Kassym-Jomart Tokayev", 2724900 },
                    { "88", "Nairobi", "Kenyan Shilling", "Kenya", 54f, "Uhuru Kenyatta", 580367 },
                    { "89", "Tarawa Atoll", "Australian Dollar", "Kiribati", 0.1f, "Taneti Maamau", 811 },
                    { "90", "Pristina", "Euro", "Kosovo", 1.8f, "Vjosa Osmani", 10908 },
                    { "91", "Kuwait City", "Kuwaiti Dinar", "Kuwait", 4.3f, "Jaber Al-Ahmad Al-Sabah", 17818 },
                    { "92", "Bishkek", "Kyrgyzstani Som", "Kyrgyzstan", 6.7f, "Sadyr Japarov", 199951 },
                    { "93", "Vientiane", "Lao Kip", "Laos", 7.4f, "Thongloun Sisoulith", 236800 },
                    { "94", "Riga", "Euro", "Latvia", 1.9f, "Egils Levits", 64589 },
                    { "95", "Beirut", "Lebanese Pound", "Lebanon", 6.8f, "Michel Aoun", 10452 },
                    { "96", "Maseru", "Lesotho Loti", "Lesotho", 2.1f, "Moeketsi Majoro", 30355 },
                    { "97", "Monrovia", "Liberian Dollar", "Liberia", 5.1f, "George Weah", 111369 },
                    { "98", "Tripoli", "Libyan Dinar", "Libya", 6.7f, "Abdul Hamid Dbeibeh", 1759540 },
                    { "99", "Vaduz", "Swiss Franc", "Liechtenstein", 0.04f, "Hans-Adam II", 160 },
                    { "100", "Vilnius", "Euro", "Lithuania", 2.8f, "Gitanas NausÄ—da", 65300 },
                    { "101", "Luxembourg", "Euro", "Luxembourg", 0.6f, "Grand Duke Henri", 2586 },
                    { "102", " Antananarivo", "Malagasy Ariary", "Madagascar", 27.4f, "Andry Rajoelina", 587041 },
                    { "103", "Lilongwe", "Malawian Kwacha", "Malawi", 19.1f, "Lazarus Chakwera", 118484 },
                    { "104", "Kuala Lumpur", "Malaysian Ringgit", "Malaysia", 32.4f, "Abdul Hamid Bador", 330803 },
                    { "105", "Male", "Maldivian Rufiyaa", "Maldives", 0.5f, "Ibrahim Mohamed Solih", 298 },
                    { "106", "Bamako", "West African CFA franc", "Mali", 20.3f, "Bah N'Daw", 1240192 },
                    { "107", "Valletta", "Euro", "Malta", 0.5f, "George Vella", 316 },
                    { "108", "Majuro", "United States Dollar", "Marshall Islands", 0.06f, "David Kabua", 181 },
                    { "109", "Nouakchott", "Mauritanian Ouguiya", "Mauritania", 4.6f, "Mohamed Ould Ghazouani", 1030700 },
                    { "110", "Port Louis", "Mauritian Rupee", "Mauritius", 1.3f, "Prithvirajsing Roopun", 2040 },
                    { "111", "Mexico City", "Mexican Peso", "Mexico", 126.2f, "AndrÃ©s Manuel LÃ³pez Obrador", 1964375 },
                    { "112", "Chisinau", "Moldovan Leu", "Moldova", 2.6f, "Maia Sandu", 33846 },
                    { "113", "Monte Carlo", "Euro", "Monaco", 0.04f, "Albert II of Monaco", 2 },
                    { "114", "Ulaanbaatar", "Mongolian Tugrik", "Mongolia", 3.3f, "Khaltmaagiin Battulga", 1564116 },
                    { "115", "Podgorica", "Euro", "Montenegro", 0.6f, "Milo ÄukanoviÄ‡", 13812 },
                    { "116", "Rabat", "Moroccan Dirham", "Morocco", 37.3f, "Mohammed VI", 446550 },
                    { "117", "Maputo", "Mozambican Met", "Mozambique", 31.4f, "Philipe Nyusi", 801590 },
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "100");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "101");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "102");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "103");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "104");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "105");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "106");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "107");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "108");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "109");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "110");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "111");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "112");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "113");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "114");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "115");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "116");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "117");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "69");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "70");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "72");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "74");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "76");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "78");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "89");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: "99");
        }
    }
}
