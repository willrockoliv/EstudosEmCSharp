namespace MediaPlayer
{
    partial class frCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCadastro));
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtCaminhoArquivoImportado = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcMidia = new System.Windows.Forms.TabControl();
            this.tbpFoto = new System.Windows.Forms.TabPage();
            this.mtbTempoExibicaoFoto = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMegapixelFoto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalFoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxAnoLancamentoFoto = new System.Windows.Forms.ComboBox();
            this.tbpVideo = new System.Windows.Forms.TabPage();
            this.ckbPossuiLegendaVideo = new System.Windows.Forms.CheckBox();
            this.cbxIdiomaVideo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxAnoLancamentoVideo = new System.Windows.Forms.ComboBox();
            this.txtFormatoVideo = new System.Windows.Forms.TextBox();
            this.tbpMusica = new System.Windows.Forms.TabPage();
            this.txtDuracaoMusica = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFormatoMusica = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PrePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbcMidia.SuspendLayout();
            this.tbpFoto.SuspendLayout();
            this.tbpVideo.SuspendLayout();
            this.tbpMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrePlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(17, 30);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 0;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtCaminhoArquivoImportado
            // 
            this.txtCaminhoArquivoImportado.BackColor = System.Drawing.Color.White;
            this.txtCaminhoArquivoImportado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaminhoArquivoImportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoArquivoImportado.Location = new System.Drawing.Point(98, 31);
            this.txtCaminhoArquivoImportado.Name = "txtCaminhoArquivoImportado";
            this.txtCaminhoArquivoImportado.ReadOnly = true;
            this.txtCaminhoArquivoImportado.Size = new System.Drawing.Size(368, 22);
            this.txtCaminhoArquivoImportado.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(98, 80);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(368, 22);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(17, 80);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(75, 22);
            this.txtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminho Arquivo";
            // 
            // tbcMidia
            // 
            this.tbcMidia.Controls.Add(this.tbpFoto);
            this.tbcMidia.Controls.Add(this.tbpVideo);
            this.tbcMidia.Controls.Add(this.tbpMusica);
            this.tbcMidia.Enabled = false;
            this.tbcMidia.Location = new System.Drawing.Point(17, 108);
            this.tbcMidia.Name = "tbcMidia";
            this.tbcMidia.SelectedIndex = 0;
            this.tbcMidia.Size = new System.Drawing.Size(449, 224);
            this.tbcMidia.TabIndex = 0;
            this.tbcMidia.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcMidia_Selected);
            // 
            // tbpFoto
            // 
            this.tbpFoto.BackColor = System.Drawing.Color.GhostWhite;
            this.tbpFoto.Controls.Add(this.mtbTempoExibicaoFoto);
            this.tbpFoto.Controls.Add(this.label7);
            this.tbpFoto.Controls.Add(this.label6);
            this.tbpFoto.Controls.Add(this.txtMegapixelFoto);
            this.tbpFoto.Controls.Add(this.label5);
            this.tbpFoto.Controls.Add(this.txtLocalFoto);
            this.tbpFoto.Controls.Add(this.label4);
            this.tbpFoto.Controls.Add(this.cbxAnoLancamentoFoto);
            this.tbpFoto.Location = new System.Drawing.Point(4, 22);
            this.tbpFoto.Name = "tbpFoto";
            this.tbpFoto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFoto.Size = new System.Drawing.Size(441, 198);
            this.tbpFoto.TabIndex = 0;
            this.tbpFoto.Text = "Foto";
            // 
            // mtbTempoExibicaoFoto
            // 
            this.mtbTempoExibicaoFoto.BackColor = System.Drawing.Color.White;
            this.mtbTempoExibicaoFoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbTempoExibicaoFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTempoExibicaoFoto.Location = new System.Drawing.Point(19, 108);
            this.mtbTempoExibicaoFoto.Mask = "000";
            this.mtbTempoExibicaoFoto.Name = "mtbTempoExibicaoFoto";
            this.mtbTempoExibicaoFoto.Size = new System.Drawing.Size(30, 22);
            this.mtbTempoExibicaoFoto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tempo de Exibição (segundos)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Megapixel";
            // 
            // txtMegapixelFoto
            // 
            this.txtMegapixelFoto.BackColor = System.Drawing.Color.White;
            this.txtMegapixelFoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMegapixelFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMegapixelFoto.Location = new System.Drawing.Point(19, 69);
            this.txtMegapixelFoto.Name = "txtMegapixelFoto";
            this.txtMegapixelFoto.ReadOnly = true;
            this.txtMegapixelFoto.Size = new System.Drawing.Size(100, 22);
            this.txtMegapixelFoto.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Local";
            // 
            // txtLocalFoto
            // 
            this.txtLocalFoto.BackColor = System.Drawing.Color.White;
            this.txtLocalFoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalFoto.Location = new System.Drawing.Point(19, 147);
            this.txtLocalFoto.Name = "txtLocalFoto";
            this.txtLocalFoto.Size = new System.Drawing.Size(274, 22);
            this.txtLocalFoto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano de Lançamento";
            // 
            // cbxAnoLancamentoFoto
            // 
            this.cbxAnoLancamentoFoto.BackColor = System.Drawing.Color.White;
            this.cbxAnoLancamentoFoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnoLancamentoFoto.FormattingEnabled = true;
            this.cbxAnoLancamentoFoto.Items.AddRange(new object[] {
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
            this.cbxAnoLancamentoFoto.Location = new System.Drawing.Point(19, 29);
            this.cbxAnoLancamentoFoto.Name = "cbxAnoLancamentoFoto";
            this.cbxAnoLancamentoFoto.Size = new System.Drawing.Size(100, 21);
            this.cbxAnoLancamentoFoto.TabIndex = 0;
            // 
            // tbpVideo
            // 
            this.tbpVideo.BackColor = System.Drawing.Color.GhostWhite;
            this.tbpVideo.Controls.Add(this.ckbPossuiLegendaVideo);
            this.tbpVideo.Controls.Add(this.cbxIdiomaVideo);
            this.tbpVideo.Controls.Add(this.label11);
            this.tbpVideo.Controls.Add(this.label9);
            this.tbpVideo.Controls.Add(this.label8);
            this.tbpVideo.Controls.Add(this.cbxAnoLancamentoVideo);
            this.tbpVideo.Controls.Add(this.txtFormatoVideo);
            this.tbpVideo.Location = new System.Drawing.Point(4, 22);
            this.tbpVideo.Name = "tbpVideo";
            this.tbpVideo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpVideo.Size = new System.Drawing.Size(441, 198);
            this.tbpVideo.TabIndex = 1;
            this.tbpVideo.Text = "Vídeo";
            // 
            // ckbPossuiLegendaVideo
            // 
            this.ckbPossuiLegendaVideo.AutoSize = true;
            this.ckbPossuiLegendaVideo.Location = new System.Drawing.Point(19, 107);
            this.ckbPossuiLegendaVideo.Name = "ckbPossuiLegendaVideo";
            this.ckbPossuiLegendaVideo.Size = new System.Drawing.Size(102, 17);
            this.ckbPossuiLegendaVideo.TabIndex = 16;
            this.ckbPossuiLegendaVideo.Text = "Possui Legenda";
            this.ckbPossuiLegendaVideo.UseVisualStyleBackColor = true;
            // 
            // cbxIdiomaVideo
            // 
            this.cbxIdiomaVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdiomaVideo.FormattingEnabled = true;
            this.cbxIdiomaVideo.Items.AddRange(new object[] {
            "Portugues",
            "Inglês",
            "Espanhol",
            "Outros"});
            this.cbxIdiomaVideo.Location = new System.Drawing.Point(19, 151);
            this.cbxIdiomaVideo.Name = "cbxIdiomaVideo";
            this.cbxIdiomaVideo.Size = new System.Drawing.Size(147, 21);
            this.cbxIdiomaVideo.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Idioma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Formato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ano de Lançamento";
            // 
            // cbxAnoLancamentoVideo
            // 
            this.cbxAnoLancamentoVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAnoLancamentoVideo.FormattingEnabled = true;
            this.cbxAnoLancamentoVideo.Items.AddRange(new object[] {
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
            this.cbxAnoLancamentoVideo.Location = new System.Drawing.Point(19, 31);
            this.cbxAnoLancamentoVideo.Name = "cbxAnoLancamentoVideo";
            this.cbxAnoLancamentoVideo.Size = new System.Drawing.Size(147, 21);
            this.cbxAnoLancamentoVideo.TabIndex = 7;
            // 
            // txtFormatoVideo
            // 
            this.txtFormatoVideo.BackColor = System.Drawing.Color.White;
            this.txtFormatoVideo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormatoVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormatoVideo.Location = new System.Drawing.Point(19, 72);
            this.txtFormatoVideo.Name = "txtFormatoVideo";
            this.txtFormatoVideo.ReadOnly = true;
            this.txtFormatoVideo.Size = new System.Drawing.Size(147, 22);
            this.txtFormatoVideo.TabIndex = 2;
            // 
            // tbpMusica
            // 
            this.tbpMusica.BackColor = System.Drawing.Color.GhostWhite;
            this.tbpMusica.Controls.Add(this.txtDuracaoMusica);
            this.tbpMusica.Controls.Add(this.label14);
            this.tbpMusica.Controls.Add(this.txtFormatoMusica);
            this.tbpMusica.Controls.Add(this.label12);
            this.tbpMusica.Location = new System.Drawing.Point(4, 22);
            this.tbpMusica.Name = "tbpMusica";
            this.tbpMusica.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMusica.Size = new System.Drawing.Size(441, 198);
            this.tbpMusica.TabIndex = 2;
            this.tbpMusica.Text = "Música";
            // 
            // txtDuracaoMusica
            // 
            this.txtDuracaoMusica.BackColor = System.Drawing.Color.White;
            this.txtDuracaoMusica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDuracaoMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracaoMusica.Location = new System.Drawing.Point(18, 29);
            this.txtDuracaoMusica.Name = "txtDuracaoMusica";
            this.txtDuracaoMusica.ReadOnly = true;
            this.txtDuracaoMusica.Size = new System.Drawing.Size(73, 22);
            this.txtDuracaoMusica.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Formato";
            // 
            // txtFormatoMusica
            // 
            this.txtFormatoMusica.BackColor = System.Drawing.Color.White;
            this.txtFormatoMusica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormatoMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormatoMusica.Location = new System.Drawing.Point(18, 69);
            this.txtFormatoMusica.Name = "txtFormatoMusica";
            this.txtFormatoMusica.ReadOnly = true;
            this.txtFormatoMusica.Size = new System.Drawing.Size(73, 22);
            this.txtFormatoMusica.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Duração (Segundos)";
            // 
            // PrePlayer
            // 
            this.PrePlayer.Enabled = true;
            this.PrePlayer.Location = new System.Drawing.Point(506, 30);
            this.PrePlayer.Name = "PrePlayer";
            this.PrePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PrePlayer.OcxState")));
            this.PrePlayer.Size = new System.Drawing.Size(478, 357);
            this.PrePlayer.TabIndex = 7;
            this.PrePlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.PrePlayer_PlayStateChange);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnImportar);
            this.groupBox1.Controls.Add(this.PrePlayer);
            this.groupBox1.Controls.Add(this.txtCaminhoArquivoImportado);
            this.groupBox1.Controls.Add(this.tbcMidia);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 744);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::MediaPlayer.Properties.Resources.if_ic_delete_48px_352303;
            this.btnExcluir.Location = new System.Drawing.Point(472, 100);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(28, 28);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::MediaPlayer.Properties.Resources._new;
            this.btnNovo.Location = new System.Drawing.Point(472, 66);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(28, 28);
            this.btnNovo.TabIndex = 11;
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::MediaPlayer.Properties.Resources.lupa1;
            this.btnPesquisa.Location = new System.Drawing.Point(472, 32);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(28, 28);
            this.btnPesquisa.TabIndex = 10;
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::MediaPlayer.Properties.Resources.if_cancel_326554;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(356, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 49);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::MediaPlayer.Properties.Resources._1499384406_Select;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(261, 338);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(89, 49);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar  ";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Mídia";
            this.Load += new System.EventHandler(this.frCadastro_Load);
            this.tbcMidia.ResumeLayout(false);
            this.tbpFoto.ResumeLayout(false);
            this.tbpFoto.PerformLayout();
            this.tbpVideo.ResumeLayout(false);
            this.tbpVideo.PerformLayout();
            this.tbpMusica.ResumeLayout(false);
            this.tbpMusica.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrePlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtCaminhoArquivoImportado;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tbcMidia;
        private System.Windows.Forms.TabPage tbpFoto;
        private System.Windows.Forms.TabPage tbpVideo;
        private System.Windows.Forms.TabPage tbpMusica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxAnoLancamentoFoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMegapixelFoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxAnoLancamentoVideo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFormatoVideo;
        private System.Windows.Forms.ComboBox cbxIdiomaVideo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbTempoExibicaoFoto;
        private System.Windows.Forms.Label label12;
        private AxWMPLib.AxWindowsMediaPlayer PrePlayer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtFormatoMusica;
        private System.Windows.Forms.TextBox txtDuracaoMusica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckbPossuiLegendaVideo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnPesquisa;
    }
}