namespace MediaPlayer.Telas
{
    partial class frPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcPlaylist = new System.Windows.Forms.TabControl();
            this.tbpNovo = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlaylistNomeNovo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxAnoLancamentoNovo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxMidiaNovo = new System.Windows.Forms.ComboBox();
            this.cbxTipoMidiaNovo = new System.Windows.Forms.ComboBox();
            this.btnAddMidiaNovo = new System.Windows.Forms.Button();
            this.tbpAlterar = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnAddMidiaAlterar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cbxOutrasMidiasAlterar = new System.Windows.Forms.ComboBox();
            this.cbxAnoLancamentoAlterar = new System.Windows.Forms.ComboBox();
            this.cbxtipoMidiaAlterar = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMidiasPlaylistAlterar = new System.Windows.Forms.ComboBox();
            this.cbxPlaylistNomeAlterar = new System.Windows.Forms.ComboBox();
            this.btnLimparPlaylist = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoverItemPlaylist = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.ltbPlaylist = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.tbcPlaylist.SuspendLayout();
            this.tbpNovo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tbpAlterar.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.tbcPlaylist);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Midias";
            // 
            // tbcPlaylist
            // 
            this.tbcPlaylist.Controls.Add(this.tbpNovo);
            this.tbcPlaylist.Controls.Add(this.tbpAlterar);
            this.tbcPlaylist.Location = new System.Drawing.Point(6, 19);
            this.tbcPlaylist.Name = "tbcPlaylist";
            this.tbcPlaylist.SelectedIndex = 0;
            this.tbcPlaylist.Size = new System.Drawing.Size(972, 175);
            this.tbcPlaylist.TabIndex = 0;
            this.tbcPlaylist.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbpNovo
            // 
            this.tbpNovo.BackColor = System.Drawing.Color.GhostWhite;
            this.tbpNovo.Controls.Add(this.groupBox5);
            this.tbpNovo.Controls.Add(this.btnAddMidiaNovo);
            this.tbpNovo.Location = new System.Drawing.Point(4, 22);
            this.tbpNovo.Name = "tbpNovo";
            this.tbpNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNovo.Size = new System.Drawing.Size(964, 149);
            this.tbpNovo.TabIndex = 0;
            this.tbpNovo.Text = "Novo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtPlaylistNomeNovo);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.cbxAnoLancamentoNovo);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cbxMidiaNovo);
            this.groupBox5.Controls.Add(this.cbxTipoMidiaNovo);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(952, 64);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parâmetros";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(370, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Ano de Lançamento";
            // 
            // txtPlaylistNomeNovo
            // 
            this.txtPlaylistNomeNovo.BackColor = System.Drawing.Color.White;
            this.txtPlaylistNomeNovo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlaylistNomeNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaylistNomeNovo.Location = new System.Drawing.Point(27, 33);
            this.txtPlaylistNomeNovo.Name = "txtPlaylistNomeNovo";
            this.txtPlaylistNomeNovo.Size = new System.Drawing.Size(219, 22);
            this.txtPlaylistNomeNovo.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(249, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Tipo de Mídia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mídias";
            // 
            // cbxAnoLancamentoNovo
            // 
            this.cbxAnoLancamentoNovo.FormattingEnabled = true;
            this.cbxAnoLancamentoNovo.Items.AddRange(new object[] {
            "",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900",
            "1899",
            "1898",
            "1897",
            "1896",
            "1895",
            "1894",
            "1893",
            "1892",
            "1891",
            "1890",
            "1889",
            "1888",
            "1887",
            "1886",
            "1885",
            "1884",
            "1883",
            "1882",
            "1881",
            "1880",
            "1879",
            "1878",
            "1877",
            "1876",
            "1875",
            "1874",
            "1873",
            "1872",
            "1871",
            "1870",
            "1869",
            "1868",
            "1867",
            "1866",
            "1865",
            "1864",
            "1863",
            "1862",
            "1861",
            "1860",
            "1859",
            "1858",
            "1857",
            "1856",
            "1855",
            "1854",
            "1853",
            "1852",
            "1851",
            "1850",
            "1849",
            "1848",
            "1847",
            "1846",
            "1845",
            "1844",
            "1843",
            "1842",
            "1841",
            "1840",
            "1839",
            "1838",
            "1837",
            "1836",
            "1835",
            "1834",
            "1833",
            "1832",
            "1831",
            "1830",
            "1829",
            "1828",
            "1827",
            "1826",
            "1825",
            "1824",
            "1823",
            "1822",
            "1821",
            "1820",
            "1819",
            "1818",
            "1817",
            "1816",
            "1815",
            "1814",
            "1813",
            "1812",
            "1811",
            "1810",
            "1809",
            "1808",
            "1807",
            "1806",
            "1805",
            "1804",
            "1803",
            "1802",
            "1801",
            "1800",
            "1799",
            "1798",
            "1797",
            "1796",
            "1795",
            "1794",
            "1793",
            "1792",
            "1791",
            "1790",
            "1789",
            "1788",
            "1787",
            "1786",
            "1785",
            "1784",
            "1783",
            "1782",
            "1781",
            "1780",
            "1779",
            "1778",
            "1777",
            "1776",
            "1775",
            "1774",
            "1773",
            "1772",
            "1771",
            "1770",
            "1769",
            "1768",
            "1767",
            "1766",
            "1765",
            "1764",
            "1763",
            "1762",
            "1761",
            "1760",
            "1759",
            "1758",
            "1757",
            "1756",
            "1755",
            "1754",
            "1753",
            "1752",
            "1751",
            "1750",
            "1749",
            "1748",
            "1747",
            "1746",
            "1745",
            "1744",
            "1743",
            "1742",
            "1741",
            "1740",
            "1739",
            "1738",
            "1737",
            "1736",
            "1735",
            "1734",
            "1733",
            "1732",
            "1731",
            "1730",
            "1729",
            "1728",
            "1727",
            "1726",
            "1725",
            "1724",
            "1723",
            "1722",
            "1721",
            "1720",
            "1719",
            "1718",
            "1717",
            "1716",
            "1715",
            "1714",
            "1713",
            "1712",
            "1711",
            "1710",
            "1709",
            "1708",
            "1707",
            "1706",
            "1705",
            "1704",
            "1703",
            "1702",
            "1701",
            "1700",
            "1699",
            "1698",
            "1697",
            "1696",
            "1695",
            "1694",
            "1693",
            "1692",
            "1691",
            "1690",
            "1689",
            "1688",
            "1687",
            "1686",
            "1685",
            "1684",
            "1683",
            "1682",
            "1681",
            "1680",
            "1679",
            "1678",
            "1677",
            "1676",
            "1675",
            "1674",
            "1673",
            "1672",
            "1671",
            "1670",
            "1669",
            "1668",
            "1667",
            "1666",
            "1665",
            "1664",
            "1663",
            "1662",
            "1661",
            "1660",
            "1659",
            "1658",
            "1657",
            "1656",
            "1655",
            "1654",
            "1653",
            "1652",
            "1651",
            "1650",
            "1649",
            "1648",
            "1647",
            "1646",
            "1645",
            "1644",
            "1643",
            "1642",
            "1641",
            "1640",
            "1639",
            "1638",
            "1637",
            "1636",
            "1635",
            "1634",
            "1633",
            "1632",
            "1631",
            "1630",
            "1629",
            "1628",
            "1627",
            "1626",
            "1625",
            "1624",
            "1623",
            "1622",
            "1621",
            "1620",
            "1619",
            "1618",
            "1617",
            "1616",
            "1615",
            "1614",
            "1613",
            "1612",
            "1611",
            "1610",
            "1609",
            "1608",
            "1607",
            "1606",
            "1605",
            "1604",
            "1603",
            "1602",
            "1601",
            "1600",
            "1599",
            "1598",
            "1597",
            "1596",
            "1595",
            "1594",
            "1593",
            "1592",
            "1591",
            "1590",
            "1589",
            "1588",
            "1587",
            "1586",
            "1585",
            "1584",
            "1583",
            "1582",
            "1581",
            "1580",
            "1579",
            "1578",
            "1577",
            "1576",
            "1575",
            "1574",
            "1573",
            "1572",
            "1571",
            "1570",
            "1569",
            "1568",
            "1567",
            "1566",
            "1565",
            "1564",
            "1563",
            "1562",
            "1561",
            "1560",
            "1559",
            "1558",
            "1557",
            "1556",
            "1555",
            "1554",
            "1553",
            "1552",
            "1551",
            "1550",
            "1549",
            "1548",
            "1547",
            "1546",
            "1545",
            "1544",
            "1543",
            "1542",
            "1541",
            "1540",
            "1539",
            "1538",
            "1537",
            "1536",
            "1535",
            "1534",
            "1533",
            "1532",
            "1531",
            "1530",
            "1529",
            "1528",
            "1527",
            "1526",
            "1525",
            "1524",
            "1523",
            "1522",
            "1521",
            "1520",
            "1519",
            "1518",
            "1517",
            "1516",
            "1515",
            "1514",
            "1513",
            "1512",
            "1511",
            "1510",
            "1509",
            "1508",
            "1507",
            "1506",
            "1505",
            "1504",
            "1503",
            "1502",
            "1501",
            "1500"});
            this.cbxAnoLancamentoNovo.Location = new System.Drawing.Point(373, 33);
            this.cbxAnoLancamentoNovo.Name = "cbxAnoLancamentoNovo";
            this.cbxAnoLancamentoNovo.Size = new System.Drawing.Size(120, 21);
            this.cbxAnoLancamentoNovo.TabIndex = 28;
            this.cbxAnoLancamentoNovo.SelectedIndexChanged += new System.EventHandler(this.cbxAnoLancamentoNovo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nome da Playlist";
            // 
            // cbxMidiaNovo
            // 
            this.cbxMidiaNovo.FormattingEnabled = true;
            this.cbxMidiaNovo.Location = new System.Drawing.Point(499, 33);
            this.cbxMidiaNovo.Name = "cbxMidiaNovo";
            this.cbxMidiaNovo.Size = new System.Drawing.Size(385, 21);
            this.cbxMidiaNovo.TabIndex = 1;
            // 
            // cbxTipoMidiaNovo
            // 
            this.cbxTipoMidiaNovo.FormattingEnabled = true;
            this.cbxTipoMidiaNovo.Items.AddRange(new object[] {
            "",
            "Foto",
            "Video",
            "Musica"});
            this.cbxTipoMidiaNovo.Location = new System.Drawing.Point(252, 33);
            this.cbxTipoMidiaNovo.Name = "cbxTipoMidiaNovo";
            this.cbxTipoMidiaNovo.Size = new System.Drawing.Size(115, 21);
            this.cbxTipoMidiaNovo.TabIndex = 27;
            this.cbxTipoMidiaNovo.SelectedIndexChanged += new System.EventHandler(this.cbxTipoMidiaNovo_SelectedIndexChanged);
            // 
            // btnAddMidiaNovo
            // 
            this.btnAddMidiaNovo.Image = global::MediaPlayer.Properties.Resources.if_sign_add_299068;
            this.btnAddMidiaNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMidiaNovo.Location = new System.Drawing.Point(393, 82);
            this.btnAddMidiaNovo.Name = "btnAddMidiaNovo";
            this.btnAddMidiaNovo.Size = new System.Drawing.Size(94, 49);
            this.btnAddMidiaNovo.TabIndex = 17;
            this.btnAddMidiaNovo.Text = "Adicionar ";
            this.btnAddMidiaNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMidiaNovo.UseVisualStyleBackColor = true;
            this.btnAddMidiaNovo.Click += new System.EventHandler(this.btnAddMidiaNovo_Click);
            // 
            // tbpAlterar
            // 
            this.tbpAlterar.BackColor = System.Drawing.Color.GhostWhite;
            this.tbpAlterar.Controls.Add(this.groupBox7);
            this.tbpAlterar.Controls.Add(this.groupBox4);
            this.tbpAlterar.Location = new System.Drawing.Point(4, 22);
            this.tbpAlterar.Name = "tbpAlterar";
            this.tbpAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlterar.Size = new System.Drawing.Size(964, 149);
            this.tbpAlterar.TabIndex = 1;
            this.tbpAlterar.Text = "Alterar";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnAddMidiaAlterar);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.cbxOutrasMidiasAlterar);
            this.groupBox7.Controls.Add(this.cbxAnoLancamentoAlterar);
            this.groupBox7.Controls.Add(this.cbxtipoMidiaAlterar);
            this.groupBox7.Location = new System.Drawing.Point(6, 76);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(952, 64);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Novas mídias";
            // 
            // btnAddMidiaAlterar
            // 
            this.btnAddMidiaAlterar.Image = global::MediaPlayer.Properties.Resources.if_sign_add_299068__2_;
            this.btnAddMidiaAlterar.Location = new System.Drawing.Point(890, 26);
            this.btnAddMidiaAlterar.Name = "btnAddMidiaAlterar";
            this.btnAddMidiaAlterar.Size = new System.Drawing.Size(28, 28);
            this.btnAddMidiaAlterar.TabIndex = 17;
            this.btnAddMidiaAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMidiaAlterar.UseVisualStyleBackColor = true;
            this.btnAddMidiaAlterar.Click += new System.EventHandler(this.btnAddMidiaAlterar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(145, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ano de Lançamento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(271, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Outras Mídias";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 29;
            this.label18.Text = "Tipo de Mídia";
            // 
            // cbxOutrasMidiasAlterar
            // 
            this.cbxOutrasMidiasAlterar.FormattingEnabled = true;
            this.cbxOutrasMidiasAlterar.Location = new System.Drawing.Point(274, 33);
            this.cbxOutrasMidiasAlterar.Name = "cbxOutrasMidiasAlterar";
            this.cbxOutrasMidiasAlterar.Size = new System.Drawing.Size(610, 21);
            this.cbxOutrasMidiasAlterar.TabIndex = 15;
            // 
            // cbxAnoLancamentoAlterar
            // 
            this.cbxAnoLancamentoAlterar.FormattingEnabled = true;
            this.cbxAnoLancamentoAlterar.Items.AddRange(new object[] {
            "",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900",
            "1899",
            "1898",
            "1897",
            "1896",
            "1895",
            "1894",
            "1893",
            "1892",
            "1891",
            "1890",
            "1889",
            "1888",
            "1887",
            "1886",
            "1885",
            "1884",
            "1883",
            "1882",
            "1881",
            "1880",
            "1879",
            "1878",
            "1877",
            "1876",
            "1875",
            "1874",
            "1873",
            "1872",
            "1871",
            "1870",
            "1869",
            "1868",
            "1867",
            "1866",
            "1865",
            "1864",
            "1863",
            "1862",
            "1861",
            "1860",
            "1859",
            "1858",
            "1857",
            "1856",
            "1855",
            "1854",
            "1853",
            "1852",
            "1851",
            "1850",
            "1849",
            "1848",
            "1847",
            "1846",
            "1845",
            "1844",
            "1843",
            "1842",
            "1841",
            "1840",
            "1839",
            "1838",
            "1837",
            "1836",
            "1835",
            "1834",
            "1833",
            "1832",
            "1831",
            "1830",
            "1829",
            "1828",
            "1827",
            "1826",
            "1825",
            "1824",
            "1823",
            "1822",
            "1821",
            "1820",
            "1819",
            "1818",
            "1817",
            "1816",
            "1815",
            "1814",
            "1813",
            "1812",
            "1811",
            "1810",
            "1809",
            "1808",
            "1807",
            "1806",
            "1805",
            "1804",
            "1803",
            "1802",
            "1801",
            "1800",
            "1799",
            "1798",
            "1797",
            "1796",
            "1795",
            "1794",
            "1793",
            "1792",
            "1791",
            "1790",
            "1789",
            "1788",
            "1787",
            "1786",
            "1785",
            "1784",
            "1783",
            "1782",
            "1781",
            "1780",
            "1779",
            "1778",
            "1777",
            "1776",
            "1775",
            "1774",
            "1773",
            "1772",
            "1771",
            "1770",
            "1769",
            "1768",
            "1767",
            "1766",
            "1765",
            "1764",
            "1763",
            "1762",
            "1761",
            "1760",
            "1759",
            "1758",
            "1757",
            "1756",
            "1755",
            "1754",
            "1753",
            "1752",
            "1751",
            "1750",
            "1749",
            "1748",
            "1747",
            "1746",
            "1745",
            "1744",
            "1743",
            "1742",
            "1741",
            "1740",
            "1739",
            "1738",
            "1737",
            "1736",
            "1735",
            "1734",
            "1733",
            "1732",
            "1731",
            "1730",
            "1729",
            "1728",
            "1727",
            "1726",
            "1725",
            "1724",
            "1723",
            "1722",
            "1721",
            "1720",
            "1719",
            "1718",
            "1717",
            "1716",
            "1715",
            "1714",
            "1713",
            "1712",
            "1711",
            "1710",
            "1709",
            "1708",
            "1707",
            "1706",
            "1705",
            "1704",
            "1703",
            "1702",
            "1701",
            "1700",
            "1699",
            "1698",
            "1697",
            "1696",
            "1695",
            "1694",
            "1693",
            "1692",
            "1691",
            "1690",
            "1689",
            "1688",
            "1687",
            "1686",
            "1685",
            "1684",
            "1683",
            "1682",
            "1681",
            "1680",
            "1679",
            "1678",
            "1677",
            "1676",
            "1675",
            "1674",
            "1673",
            "1672",
            "1671",
            "1670",
            "1669",
            "1668",
            "1667",
            "1666",
            "1665",
            "1664",
            "1663",
            "1662",
            "1661",
            "1660",
            "1659",
            "1658",
            "1657",
            "1656",
            "1655",
            "1654",
            "1653",
            "1652",
            "1651",
            "1650",
            "1649",
            "1648",
            "1647",
            "1646",
            "1645",
            "1644",
            "1643",
            "1642",
            "1641",
            "1640",
            "1639",
            "1638",
            "1637",
            "1636",
            "1635",
            "1634",
            "1633",
            "1632",
            "1631",
            "1630",
            "1629",
            "1628",
            "1627",
            "1626",
            "1625",
            "1624",
            "1623",
            "1622",
            "1621",
            "1620",
            "1619",
            "1618",
            "1617",
            "1616",
            "1615",
            "1614",
            "1613",
            "1612",
            "1611",
            "1610",
            "1609",
            "1608",
            "1607",
            "1606",
            "1605",
            "1604",
            "1603",
            "1602",
            "1601",
            "1600",
            "1599",
            "1598",
            "1597",
            "1596",
            "1595",
            "1594",
            "1593",
            "1592",
            "1591",
            "1590",
            "1589",
            "1588",
            "1587",
            "1586",
            "1585",
            "1584",
            "1583",
            "1582",
            "1581",
            "1580",
            "1579",
            "1578",
            "1577",
            "1576",
            "1575",
            "1574",
            "1573",
            "1572",
            "1571",
            "1570",
            "1569",
            "1568",
            "1567",
            "1566",
            "1565",
            "1564",
            "1563",
            "1562",
            "1561",
            "1560",
            "1559",
            "1558",
            "1557",
            "1556",
            "1555",
            "1554",
            "1553",
            "1552",
            "1551",
            "1550",
            "1549",
            "1548",
            "1547",
            "1546",
            "1545",
            "1544",
            "1543",
            "1542",
            "1541",
            "1540",
            "1539",
            "1538",
            "1537",
            "1536",
            "1535",
            "1534",
            "1533",
            "1532",
            "1531",
            "1530",
            "1529",
            "1528",
            "1527",
            "1526",
            "1525",
            "1524",
            "1523",
            "1522",
            "1521",
            "1520",
            "1519",
            "1518",
            "1517",
            "1516",
            "1515",
            "1514",
            "1513",
            "1512",
            "1511",
            "1510",
            "1509",
            "1508",
            "1507",
            "1506",
            "1505",
            "1504",
            "1503",
            "1502",
            "1501",
            "1500"});
            this.cbxAnoLancamentoAlterar.Location = new System.Drawing.Point(148, 33);
            this.cbxAnoLancamentoAlterar.Name = "cbxAnoLancamentoAlterar";
            this.cbxAnoLancamentoAlterar.Size = new System.Drawing.Size(120, 21);
            this.cbxAnoLancamentoAlterar.TabIndex = 28;
            this.cbxAnoLancamentoAlterar.SelectedIndexChanged += new System.EventHandler(this.cbxAnoLancamentoAlterar_SelectedIndexChanged);
            // 
            // cbxtipoMidiaAlterar
            // 
            this.cbxtipoMidiaAlterar.FormattingEnabled = true;
            this.cbxtipoMidiaAlterar.Items.AddRange(new object[] {
            "",
            "Foto",
            "Video",
            "Musica"});
            this.cbxtipoMidiaAlterar.Location = new System.Drawing.Point(27, 33);
            this.cbxtipoMidiaAlterar.Name = "cbxtipoMidiaAlterar";
            this.cbxtipoMidiaAlterar.Size = new System.Drawing.Size(115, 21);
            this.cbxtipoMidiaAlterar.TabIndex = 27;
            this.cbxtipoMidiaAlterar.SelectedIndexChanged += new System.EventHandler(this.cbxtipoMidiaAlterar_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.cbxMidiasPlaylistAlterar);
            this.groupBox4.Controls.Add(this.cbxPlaylistNomeAlterar);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(952, 64);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadastradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mídias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Playlist";
            // 
            // cbxMidiasPlaylistAlterar
            // 
            this.cbxMidiasPlaylistAlterar.FormattingEnabled = true;
            this.cbxMidiasPlaylistAlterar.Location = new System.Drawing.Point(274, 33);
            this.cbxMidiasPlaylistAlterar.Name = "cbxMidiasPlaylistAlterar";
            this.cbxMidiasPlaylistAlterar.Size = new System.Drawing.Size(610, 21);
            this.cbxMidiasPlaylistAlterar.TabIndex = 1;
            // 
            // cbxPlaylistNomeAlterar
            // 
            this.cbxPlaylistNomeAlterar.FormattingEnabled = true;
            this.cbxPlaylistNomeAlterar.Location = new System.Drawing.Point(27, 33);
            this.cbxPlaylistNomeAlterar.Name = "cbxPlaylistNomeAlterar";
            this.cbxPlaylistNomeAlterar.Size = new System.Drawing.Size(241, 21);
            this.cbxPlaylistNomeAlterar.TabIndex = 0;
            this.cbxPlaylistNomeAlterar.SelectedIndexChanged += new System.EventHandler(this.cbxPlaylistNomeAlterar_SelectedIndexChanged);
            // 
            // btnLimparPlaylist
            // 
            this.btnLimparPlaylist.Image = global::MediaPlayer.Properties.Resources.if_Vector_icons_55_1041645;
            this.btnLimparPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparPlaylist.Location = new System.Drawing.Point(884, 129);
            this.btnLimparPlaylist.Name = "btnLimparPlaylist";
            this.btnLimparPlaylist.Size = new System.Drawing.Size(94, 49);
            this.btnLimparPlaylist.TabIndex = 22;
            this.btnLimparPlaylist.Text = "Limpar   ";
            this.btnLimparPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparPlaylist.UseVisualStyleBackColor = true;
            this.btnLimparPlaylist.Click += new System.EventHandler(this.btnLimparPlaylist_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Lavender;
            this.groupBox2.Controls.Add(this.btnLimparPlaylist);
            this.groupBox2.Controls.Add(this.btnRemoverItemPlaylist);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.ltbPlaylist);
            this.groupBox2.Location = new System.Drawing.Point(12, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 499);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playlist";
            // 
            // btnRemoverItemPlaylist
            // 
            this.btnRemoverItemPlaylist.Image = global::MediaPlayer.Properties.Resources.if_ic_delete_48px_352303__1_;
            this.btnRemoverItemPlaylist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverItemPlaylist.Location = new System.Drawing.Point(883, 74);
            this.btnRemoverItemPlaylist.Name = "btnRemoverItemPlaylist";
            this.btnRemoverItemPlaylist.Size = new System.Drawing.Size(94, 49);
            this.btnRemoverItemPlaylist.TabIndex = 12;
            this.btnRemoverItemPlaylist.Text = "Remover ";
            this.btnRemoverItemPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverItemPlaylist.UseVisualStyleBackColor = true;
            this.btnRemoverItemPlaylist.Click += new System.EventHandler(this.btnRemoverItemPlaylist_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MediaPlayer.Properties.Resources.if_cancel_326554;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(884, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 49);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::MediaPlayer.Properties.Resources._1499384406_Select;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(883, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 49);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar    ";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // ltbPlaylist
            // 
            this.ltbPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPlaylist.FormattingEnabled = true;
            this.ltbPlaylist.ItemHeight = 25;
            this.ltbPlaylist.Location = new System.Drawing.Point(6, 19);
            this.ltbPlaylist.Name = "ltbPlaylist";
            this.ltbPlaylist.Size = new System.Drawing.Size(871, 454);
            this.ltbPlaylist.TabIndex = 0;
            // 
            // frPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.frPlaylist_Load);
            this.groupBox1.ResumeLayout(false);
            this.tbcPlaylist.ResumeLayout(false);
            this.tbpNovo.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tbpAlterar.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPlaylistNomeNovo;
        private System.Windows.Forms.TabControl tbcPlaylist;
        private System.Windows.Forms.TabPage tbpNovo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddMidiaNovo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxMidiaNovo;
        private System.Windows.Forms.TabPage tbpAlterar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddMidiaAlterar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxOutrasMidiasAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMidiasPlaylistAlterar;
        private System.Windows.Forms.ComboBox cbxPlaylistNomeAlterar;
        private System.Windows.Forms.ListBox ltbPlaylist;
        private System.Windows.Forms.Button btnRemoverItemPlaylist;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimparPlaylist;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxAnoLancamentoNovo;
        private System.Windows.Forms.ComboBox cbxTipoMidiaNovo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbxAnoLancamentoAlterar;
        private System.Windows.Forms.ComboBox cbxtipoMidiaAlterar;
    }
}