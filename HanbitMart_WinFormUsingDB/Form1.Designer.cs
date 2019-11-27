namespace HanbitMart_WinFormUsingDB
{
    partial class HANBIT_MART_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ManagementTab = new System.Windows.Forms.TabControl();
            this.customerTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cusNameBox = new System.Windows.Forms.TextBox();
            this.cusRangeLabel = new System.Windows.Forms.Label();
            this.cusIDLablel = new System.Windows.Forms.Label();
            this.cusJobComboBox = new System.Windows.Forms.ComboBox();
            this.cusIdBox = new System.Windows.Forms.TextBox();
            this.cusGradeComboBox = new System.Windows.Forms.ComboBox();
            this.cusNameLabel = new System.Windows.Forms.Label();
            this.cusAccumulationBox_max = new System.Windows.Forms.TextBox();
            this.cusAgeLabel = new System.Windows.Forms.Label();
            this.cusAgeBox = new System.Windows.Forms.TextBox();
            this.cusAccumulationBox_min = new System.Windows.Forms.TextBox();
            this.cusGradeLabel = new System.Windows.Forms.Label();
            this.cusAccumulationLabel = new System.Windows.Forms.Label();
            this.cusJobLabel = new System.Windows.Forms.Label();
            this.cusOthersBtn = new System.Windows.Forms.Button();
            this.cusClearBtn = new System.Windows.Forms.Button();
            this.cusSelectBtn = new System.Windows.Forms.Button();
            this.productTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.proProductNameBox = new System.Windows.Forms.TextBox();
            this.proStockBox_max = new System.Windows.Forms.TextBox();
            this.proProductNumberLabel = new System.Windows.Forms.Label();
            this.proRangeLabel = new System.Windows.Forms.Label();
            this.proProductNameLabel = new System.Windows.Forms.Label();
            this.proProductNumberComboBox = new System.Windows.Forms.ComboBox();
            this.proStockLabel = new System.Windows.Forms.Label();
            this.proManufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.proStockBox_min = new System.Windows.Forms.TextBox();
            this.proPriceBox_max = new System.Windows.Forms.TextBox();
            this.proManufacturerLabel = new System.Windows.Forms.Label();
            this.proRangeLabel2 = new System.Windows.Forms.Label();
            this.proPriceLabel = new System.Windows.Forms.Label();
            this.proPriceBox_min = new System.Windows.Forms.TextBox();
            this.proOthersBtn = new System.Windows.Forms.Button();
            this.proClearBtn = new System.Windows.Forms.Button();
            this.proSelectBtn = new System.Windows.Forms.Button();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.ordOrderDateComboBox = new System.Windows.Forms.ComboBox();
            this.ordProductNumberComboBox = new System.Windows.Forms.ComboBox();
            this.ordQuantityBox_max = new System.Windows.Forms.TextBox();
            this.ordRangeLabel = new System.Windows.Forms.Label();
            this.ordOthersBtn = new System.Windows.Forms.Button();
            this.ordQuantityBox_min = new System.Windows.Forms.TextBox();
            this.ordOrderDateLabel = new System.Windows.Forms.Label();
            this.ordClearBtn = new System.Windows.Forms.Button();
            this.ordQuantityLabel = new System.Windows.Forms.Label();
            this.ordDestinationLabel = new System.Windows.Forms.Label();
            this.ordDestinationBox = new System.Windows.Forms.TextBox();
            this.ordProductNumberLabel = new System.Windows.Forms.Label();
            this.ordCustomerBox = new System.Windows.Forms.TextBox();
            this.ordOrderCustomerLabel = new System.Windows.Forms.Label();
            this.ordSelectBtn = new System.Windows.Forms.Button();
            this.ordOrderNumberBox = new System.Windows.Forms.TextBox();
            this.ordOrderNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.areaDB = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ManagementTab.SuspendLayout();
            this.customerTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.productTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.orderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaDB)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "한빛마트 관리창";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(385, 336);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ManagementTab
            // 
            this.ManagementTab.Controls.Add(this.customerTab);
            this.ManagementTab.Controls.Add(this.productTab);
            this.ManagementTab.Controls.Add(this.orderTab);
            this.ManagementTab.Location = new System.Drawing.Point(-4, 62);
            this.ManagementTab.Name = "ManagementTab";
            this.ManagementTab.SelectedIndex = 0;
            this.ManagementTab.Size = new System.Drawing.Size(734, 218);
            this.ManagementTab.TabIndex = 19;
            this.ManagementTab.SelectedIndexChanged += new System.EventHandler(this.ManagementTab_SelectedIndexChanged);
            // 
            // customerTab
            // 
            this.customerTab.BackColor = System.Drawing.Color.NavajoWhite;
            this.customerTab.Controls.Add(this.label3);
            this.customerTab.Controls.Add(this.panel1);
            this.customerTab.Controls.Add(this.cusOthersBtn);
            this.customerTab.Controls.Add(this.cusClearBtn);
            this.customerTab.Controls.Add(this.cusSelectBtn);
            this.customerTab.Location = new System.Drawing.Point(4, 22);
            this.customerTab.Name = "customerTab";
            this.customerTab.Padding = new System.Windows.Forms.Padding(3);
            this.customerTab.Size = new System.Drawing.Size(726, 192);
            this.customerTab.TabIndex = 0;
            this.customerTab.Text = "고객";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "데이터 검색";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cusNameBox);
            this.panel1.Controls.Add(this.cusRangeLabel);
            this.panel1.Controls.Add(this.cusIDLablel);
            this.panel1.Controls.Add(this.cusJobComboBox);
            this.panel1.Controls.Add(this.cusIdBox);
            this.panel1.Controls.Add(this.cusGradeComboBox);
            this.panel1.Controls.Add(this.cusNameLabel);
            this.panel1.Controls.Add(this.cusAccumulationBox_max);
            this.panel1.Controls.Add(this.cusAgeLabel);
            this.panel1.Controls.Add(this.cusAgeBox);
            this.panel1.Controls.Add(this.cusAccumulationBox_min);
            this.panel1.Controls.Add(this.cusGradeLabel);
            this.panel1.Controls.Add(this.cusAccumulationLabel);
            this.panel1.Controls.Add(this.cusJobLabel);
            this.panel1.Location = new System.Drawing.Point(46, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 166);
            this.panel1.TabIndex = 26;
            // 
            // cusNameBox
            // 
            this.cusNameBox.Location = new System.Drawing.Point(239, 25);
            this.cusNameBox.Name = "cusNameBox";
            this.cusNameBox.Size = new System.Drawing.Size(100, 21);
            this.cusNameBox.TabIndex = 7;
            // 
            // cusRangeLabel
            // 
            this.cusRangeLabel.AutoSize = true;
            this.cusRangeLabel.Location = new System.Drawing.Point(265, 118);
            this.cusRangeLabel.Name = "cusRangeLabel";
            this.cusRangeLabel.Size = new System.Drawing.Size(14, 12);
            this.cusRangeLabel.TabIndex = 25;
            this.cusRangeLabel.Text = "~";
            // 
            // cusIDLablel
            // 
            this.cusIDLablel.AutoSize = true;
            this.cusIDLablel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusIDLablel.Location = new System.Drawing.Point(16, 28);
            this.cusIDLablel.Name = "cusIDLablel";
            this.cusIDLablel.Size = new System.Drawing.Size(72, 13);
            this.cusIDLablel.TabIndex = 3;
            this.cusIDLablel.Text = "고객아이디";
            // 
            // cusJobComboBox
            // 
            this.cusJobComboBox.FormattingEnabled = true;
            this.cusJobComboBox.Location = new System.Drawing.Point(189, 69);
            this.cusJobComboBox.Name = "cusJobComboBox";
            this.cusJobComboBox.Size = new System.Drawing.Size(104, 20);
            this.cusJobComboBox.TabIndex = 24;
            // 
            // cusIdBox
            // 
            this.cusIdBox.Location = new System.Drawing.Point(90, 25);
            this.cusIdBox.Name = "cusIdBox";
            this.cusIdBox.Size = new System.Drawing.Size(74, 21);
            this.cusIdBox.TabIndex = 4;
            // 
            // cusGradeComboBox
            // 
            this.cusGradeComboBox.FormattingEnabled = true;
            this.cusGradeComboBox.Location = new System.Drawing.Point(56, 114);
            this.cusGradeComboBox.Name = "cusGradeComboBox";
            this.cusGradeComboBox.Size = new System.Drawing.Size(79, 20);
            this.cusGradeComboBox.TabIndex = 23;
            // 
            // cusNameLabel
            // 
            this.cusNameLabel.AutoSize = true;
            this.cusNameLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusNameLabel.Location = new System.Drawing.Point(178, 28);
            this.cusNameLabel.Name = "cusNameLabel";
            this.cusNameLabel.Size = new System.Drawing.Size(59, 13);
            this.cusNameLabel.TabIndex = 6;
            this.cusNameLabel.Text = "고객이름";
            // 
            // cusAccumulationBox_max
            // 
            this.cusAccumulationBox_max.Location = new System.Drawing.Point(286, 113);
            this.cusAccumulationBox_max.Name = "cusAccumulationBox_max";
            this.cusAccumulationBox_max.Size = new System.Drawing.Size(53, 21);
            this.cusAccumulationBox_max.TabIndex = 22;
            // 
            // cusAgeLabel
            // 
            this.cusAgeLabel.AutoSize = true;
            this.cusAgeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusAgeLabel.Location = new System.Drawing.Point(17, 71);
            this.cusAgeLabel.Name = "cusAgeLabel";
            this.cusAgeLabel.Size = new System.Drawing.Size(33, 13);
            this.cusAgeLabel.TabIndex = 8;
            this.cusAgeLabel.Text = "나이";
            // 
            // cusAgeBox
            // 
            this.cusAgeBox.Location = new System.Drawing.Point(56, 69);
            this.cusAgeBox.Name = "cusAgeBox";
            this.cusAgeBox.Size = new System.Drawing.Size(79, 21);
            this.cusAgeBox.TabIndex = 9;
            // 
            // cusAccumulationBox_min
            // 
            this.cusAccumulationBox_min.Location = new System.Drawing.Point(204, 113);
            this.cusAccumulationBox_min.Name = "cusAccumulationBox_min";
            this.cusAccumulationBox_min.Size = new System.Drawing.Size(54, 21);
            this.cusAccumulationBox_min.TabIndex = 19;
            // 
            // cusGradeLabel
            // 
            this.cusGradeLabel.AutoSize = true;
            this.cusGradeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusGradeLabel.Location = new System.Drawing.Point(16, 117);
            this.cusGradeLabel.Name = "cusGradeLabel";
            this.cusGradeLabel.Size = new System.Drawing.Size(33, 13);
            this.cusGradeLabel.TabIndex = 10;
            this.cusGradeLabel.Text = "등급";
            // 
            // cusAccumulationLabel
            // 
            this.cusAccumulationLabel.AutoSize = true;
            this.cusAccumulationLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusAccumulationLabel.Location = new System.Drawing.Point(146, 116);
            this.cusAccumulationLabel.Name = "cusAccumulationLabel";
            this.cusAccumulationLabel.Size = new System.Drawing.Size(46, 13);
            this.cusAccumulationLabel.TabIndex = 18;
            this.cusAccumulationLabel.Text = "적립금";
            // 
            // cusJobLabel
            // 
            this.cusJobLabel.AutoSize = true;
            this.cusJobLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cusJobLabel.Location = new System.Drawing.Point(146, 72);
            this.cusJobLabel.Name = "cusJobLabel";
            this.cusJobLabel.Size = new System.Drawing.Size(33, 13);
            this.cusJobLabel.TabIndex = 12;
            this.cusJobLabel.Text = "직업";
            // 
            // cusOthersBtn
            // 
            this.cusOthersBtn.Location = new System.Drawing.Point(491, 75);
            this.cusOthersBtn.Name = "cusOthersBtn";
            this.cusOthersBtn.Size = new System.Drawing.Size(154, 44);
            this.cusOthersBtn.TabIndex = 20;
            this.cusOthersBtn.Text = "OTHERS";
            this.cusOthersBtn.UseVisualStyleBackColor = true;
            this.cusOthersBtn.Click += new System.EventHandler(this.cusOthersBtn_Click);
            // 
            // cusClearBtn
            // 
            this.cusClearBtn.Location = new System.Drawing.Point(491, 129);
            this.cusClearBtn.Name = "cusClearBtn";
            this.cusClearBtn.Size = new System.Drawing.Size(154, 44);
            this.cusClearBtn.TabIndex = 17;
            this.cusClearBtn.Text = "CLEAR";
            this.cusClearBtn.UseVisualStyleBackColor = true;
            this.cusClearBtn.Click += new System.EventHandler(this.cusClearBtn_Click);
            // 
            // cusSelectBtn
            // 
            this.cusSelectBtn.Location = new System.Drawing.Point(491, 20);
            this.cusSelectBtn.Name = "cusSelectBtn";
            this.cusSelectBtn.Size = new System.Drawing.Size(154, 44);
            this.cusSelectBtn.TabIndex = 5;
            this.cusSelectBtn.Text = "SELECT";
            this.cusSelectBtn.UseVisualStyleBackColor = true;
            this.cusSelectBtn.Click += new System.EventHandler(this.cusSelectBtn_Click);
            // 
            // productTab
            // 
            this.productTab.BackColor = System.Drawing.Color.NavajoWhite;
            this.productTab.Controls.Add(this.label4);
            this.productTab.Controls.Add(this.panel2);
            this.productTab.Controls.Add(this.proOthersBtn);
            this.productTab.Controls.Add(this.proClearBtn);
            this.productTab.Controls.Add(this.proSelectBtn);
            this.productTab.Location = new System.Drawing.Point(4, 22);
            this.productTab.Name = "productTab";
            this.productTab.Padding = new System.Windows.Forms.Padding(3);
            this.productTab.Size = new System.Drawing.Size(726, 192);
            this.productTab.TabIndex = 1;
            this.productTab.Text = "제품";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.proProductNameBox);
            this.panel2.Controls.Add(this.proStockBox_max);
            this.panel2.Controls.Add(this.proProductNumberLabel);
            this.panel2.Controls.Add(this.proRangeLabel);
            this.panel2.Controls.Add(this.proProductNameLabel);
            this.panel2.Controls.Add(this.proProductNumberComboBox);
            this.panel2.Controls.Add(this.proStockLabel);
            this.panel2.Controls.Add(this.proManufacturerComboBox);
            this.panel2.Controls.Add(this.proStockBox_min);
            this.panel2.Controls.Add(this.proPriceBox_max);
            this.panel2.Controls.Add(this.proManufacturerLabel);
            this.panel2.Controls.Add(this.proRangeLabel2);
            this.panel2.Controls.Add(this.proPriceLabel);
            this.panel2.Controls.Add(this.proPriceBox_min);
            this.panel2.Location = new System.Drawing.Point(46, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 166);
            this.panel2.TabIndex = 61;
            // 
            // proProductNameBox
            // 
            this.proProductNameBox.Location = new System.Drawing.Point(240, 25);
            this.proProductNameBox.Name = "proProductNameBox";
            this.proProductNameBox.Size = new System.Drawing.Size(100, 21);
            this.proProductNameBox.TabIndex = 46;
            // 
            // proStockBox_max
            // 
            this.proStockBox_max.Location = new System.Drawing.Point(172, 70);
            this.proStockBox_max.Name = "proStockBox_max";
            this.proStockBox_max.Size = new System.Drawing.Size(59, 21);
            this.proStockBox_max.TabIndex = 60;
            // 
            // proProductNumberLabel
            // 
            this.proProductNumberLabel.AutoSize = true;
            this.proProductNumberLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proProductNumberLabel.Location = new System.Drawing.Point(26, 28);
            this.proProductNumberLabel.Name = "proProductNumberLabel";
            this.proProductNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.proProductNumberLabel.TabIndex = 42;
            this.proProductNumberLabel.Text = "제품번호";
            // 
            // proRangeLabel
            // 
            this.proRangeLabel.AutoSize = true;
            this.proRangeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proRangeLabel.Location = new System.Drawing.Point(148, 75);
            this.proRangeLabel.Name = "proRangeLabel";
            this.proRangeLabel.Size = new System.Drawing.Size(17, 13);
            this.proRangeLabel.TabIndex = 59;
            this.proRangeLabel.Text = "~";
            // 
            // proProductNameLabel
            // 
            this.proProductNameLabel.AutoSize = true;
            this.proProductNameLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proProductNameLabel.Location = new System.Drawing.Point(179, 28);
            this.proProductNameLabel.Name = "proProductNameLabel";
            this.proProductNameLabel.Size = new System.Drawing.Size(46, 13);
            this.proProductNameLabel.TabIndex = 45;
            this.proProductNameLabel.Text = "제품명";
            // 
            // proProductNumberComboBox
            // 
            this.proProductNumberComboBox.FormattingEnabled = true;
            this.proProductNumberComboBox.Location = new System.Drawing.Point(91, 25);
            this.proProductNumberComboBox.Name = "proProductNumberComboBox";
            this.proProductNumberComboBox.Size = new System.Drawing.Size(76, 20);
            this.proProductNumberComboBox.TabIndex = 58;
            // 
            // proStockLabel
            // 
            this.proStockLabel.AutoSize = true;
            this.proStockLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proStockLabel.Location = new System.Drawing.Point(26, 72);
            this.proStockLabel.Name = "proStockLabel";
            this.proStockLabel.Size = new System.Drawing.Size(46, 13);
            this.proStockLabel.TabIndex = 47;
            this.proStockLabel.Text = "재고량";
            // 
            // proManufacturerComboBox
            // 
            this.proManufacturerComboBox.FormattingEnabled = true;
            this.proManufacturerComboBox.Location = new System.Drawing.Point(256, 114);
            this.proManufacturerComboBox.Name = "proManufacturerComboBox";
            this.proManufacturerComboBox.Size = new System.Drawing.Size(93, 20);
            this.proManufacturerComboBox.TabIndex = 57;
            // 
            // proStockBox_min
            // 
            this.proStockBox_min.Location = new System.Drawing.Point(81, 70);
            this.proStockBox_min.Name = "proStockBox_min";
            this.proStockBox_min.Size = new System.Drawing.Size(59, 21);
            this.proStockBox_min.TabIndex = 48;
            // 
            // proPriceBox_max
            // 
            this.proPriceBox_max.Location = new System.Drawing.Point(132, 113);
            this.proPriceBox_max.Name = "proPriceBox_max";
            this.proPriceBox_max.Size = new System.Drawing.Size(53, 21);
            this.proPriceBox_max.TabIndex = 56;
            // 
            // proManufacturerLabel
            // 
            this.proManufacturerLabel.AutoSize = true;
            this.proManufacturerLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proManufacturerLabel.Location = new System.Drawing.Point(191, 116);
            this.proManufacturerLabel.Name = "proManufacturerLabel";
            this.proManufacturerLabel.Size = new System.Drawing.Size(59, 13);
            this.proManufacturerLabel.TabIndex = 49;
            this.proManufacturerLabel.Text = "제조업체";
            // 
            // proRangeLabel2
            // 
            this.proRangeLabel2.AutoSize = true;
            this.proRangeLabel2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proRangeLabel2.Location = new System.Drawing.Point(109, 118);
            this.proRangeLabel2.Name = "proRangeLabel2";
            this.proRangeLabel2.Size = new System.Drawing.Size(17, 13);
            this.proRangeLabel2.TabIndex = 55;
            this.proRangeLabel2.Text = "~";
            // 
            // proPriceLabel
            // 
            this.proPriceLabel.AutoSize = true;
            this.proPriceLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.proPriceLabel.Location = new System.Drawing.Point(12, 116);
            this.proPriceLabel.Name = "proPriceLabel";
            this.proPriceLabel.Size = new System.Drawing.Size(33, 13);
            this.proPriceLabel.TabIndex = 50;
            this.proPriceLabel.Text = "단가";
            // 
            // proPriceBox_min
            // 
            this.proPriceBox_min.Location = new System.Drawing.Point(49, 113);
            this.proPriceBox_min.Name = "proPriceBox_min";
            this.proPriceBox_min.Size = new System.Drawing.Size(54, 21);
            this.proPriceBox_min.TabIndex = 53;
            // 
            // proOthersBtn
            // 
            this.proOthersBtn.Location = new System.Drawing.Point(491, 75);
            this.proOthersBtn.Name = "proOthersBtn";
            this.proOthersBtn.Size = new System.Drawing.Size(154, 44);
            this.proOthersBtn.TabIndex = 54;
            this.proOthersBtn.Text = "OTHERS";
            this.proOthersBtn.UseVisualStyleBackColor = true;
            this.proOthersBtn.Click += new System.EventHandler(this.proOthersBtn_Click);
            // 
            // proClearBtn
            // 
            this.proClearBtn.Location = new System.Drawing.Point(491, 129);
            this.proClearBtn.Name = "proClearBtn";
            this.proClearBtn.Size = new System.Drawing.Size(154, 44);
            this.proClearBtn.TabIndex = 51;
            this.proClearBtn.Text = "CLEAR";
            this.proClearBtn.UseVisualStyleBackColor = true;
            this.proClearBtn.Click += new System.EventHandler(this.proClearBtn_Click);
            // 
            // proSelectBtn
            // 
            this.proSelectBtn.Location = new System.Drawing.Point(491, 20);
            this.proSelectBtn.Name = "proSelectBtn";
            this.proSelectBtn.Size = new System.Drawing.Size(154, 44);
            this.proSelectBtn.TabIndex = 44;
            this.proSelectBtn.Text = "SELECT";
            this.proSelectBtn.UseVisualStyleBackColor = true;
            this.proSelectBtn.Click += new System.EventHandler(this.proSelectBtn_Click);
            // 
            // orderTab
            // 
            this.orderTab.BackColor = System.Drawing.Color.NavajoWhite;
            this.orderTab.Controls.Add(this.label5);
            this.orderTab.Controls.Add(this.panel3);
            this.orderTab.Controls.Add(this.ordOthersBtn);
            this.orderTab.Controls.Add(this.ordClearBtn);
            this.orderTab.Controls.Add(this.ordSelectBtn);
            this.orderTab.Location = new System.Drawing.Point(4, 22);
            this.orderTab.Name = "orderTab";
            this.orderTab.Size = new System.Drawing.Size(726, 192);
            this.orderTab.TabIndex = 2;
            this.orderTab.Text = "주문";
            // 
            // ordOrderDateComboBox
            // 
            this.ordOrderDateComboBox.FormattingEnabled = true;
            this.ordOrderDateComboBox.Location = new System.Drawing.Point(234, 114);
            this.ordOrderDateComboBox.Name = "ordOrderDateComboBox";
            this.ordOrderDateComboBox.Size = new System.Drawing.Size(104, 20);
            this.ordOrderDateComboBox.TabIndex = 52;
            // 
            // ordProductNumberComboBox
            // 
            this.ordProductNumberComboBox.FormattingEnabled = true;
            this.ordProductNumberComboBox.Location = new System.Drawing.Point(81, 69);
            this.ordProductNumberComboBox.Name = "ordProductNumberComboBox";
            this.ordProductNumberComboBox.Size = new System.Drawing.Size(66, 20);
            this.ordProductNumberComboBox.TabIndex = 51;
            // 
            // ordQuantityBox_max
            // 
            this.ordQuantityBox_max.Location = new System.Drawing.Point(284, 69);
            this.ordQuantityBox_max.Name = "ordQuantityBox_max";
            this.ordQuantityBox_max.Size = new System.Drawing.Size(53, 21);
            this.ordQuantityBox_max.TabIndex = 50;
            // 
            // ordRangeLabel
            // 
            this.ordRangeLabel.AutoSize = true;
            this.ordRangeLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordRangeLabel.Location = new System.Drawing.Point(262, 74);
            this.ordRangeLabel.Name = "ordRangeLabel";
            this.ordRangeLabel.Size = new System.Drawing.Size(17, 13);
            this.ordRangeLabel.TabIndex = 49;
            this.ordRangeLabel.Text = "~";
            // 
            // ordOthersBtn
            // 
            this.ordOthersBtn.Location = new System.Drawing.Point(491, 75);
            this.ordOthersBtn.Name = "ordOthersBtn";
            this.ordOthersBtn.Size = new System.Drawing.Size(154, 44);
            this.ordOthersBtn.TabIndex = 48;
            this.ordOthersBtn.Text = "OTHERS";
            this.ordOthersBtn.UseVisualStyleBackColor = true;
            this.ordOthersBtn.Click += new System.EventHandler(this.ordOthersBtn_Click);
            // 
            // ordQuantityBox_min
            // 
            this.ordQuantityBox_min.Location = new System.Drawing.Point(202, 69);
            this.ordQuantityBox_min.Name = "ordQuantityBox_min";
            this.ordQuantityBox_min.Size = new System.Drawing.Size(54, 21);
            this.ordQuantityBox_min.TabIndex = 47;
            // 
            // ordOrderDateLabel
            // 
            this.ordOrderDateLabel.AutoSize = true;
            this.ordOrderDateLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordOrderDateLabel.Location = new System.Drawing.Point(167, 116);
            this.ordOrderDateLabel.Name = "ordOrderDateLabel";
            this.ordOrderDateLabel.Size = new System.Drawing.Size(59, 13);
            this.ordOrderDateLabel.TabIndex = 46;
            this.ordOrderDateLabel.Text = "주문일자";
            // 
            // ordClearBtn
            // 
            this.ordClearBtn.Location = new System.Drawing.Point(491, 129);
            this.ordClearBtn.Name = "ordClearBtn";
            this.ordClearBtn.Size = new System.Drawing.Size(154, 44);
            this.ordClearBtn.TabIndex = 45;
            this.ordClearBtn.Text = "CLEAR";
            this.ordClearBtn.UseVisualStyleBackColor = true;
            this.ordClearBtn.Click += new System.EventHandler(this.ordClearBtn_Click);
            // 
            // ordQuantityLabel
            // 
            this.ordQuantityLabel.AutoSize = true;
            this.ordQuantityLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordQuantityLabel.Location = new System.Drawing.Point(160, 72);
            this.ordQuantityLabel.Name = "ordQuantityLabel";
            this.ordQuantityLabel.Size = new System.Drawing.Size(33, 13);
            this.ordQuantityLabel.TabIndex = 44;
            this.ordQuantityLabel.Text = "수량";
            // 
            // ordDestinationLabel
            // 
            this.ordDestinationLabel.AutoSize = true;
            this.ordDestinationLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordDestinationLabel.Location = new System.Drawing.Point(17, 117);
            this.ordDestinationLabel.Name = "ordDestinationLabel";
            this.ordDestinationLabel.Size = new System.Drawing.Size(46, 13);
            this.ordDestinationLabel.TabIndex = 43;
            this.ordDestinationLabel.Text = "배송지";
            // 
            // ordDestinationBox
            // 
            this.ordDestinationBox.Location = new System.Drawing.Point(68, 114);
            this.ordDestinationBox.Name = "ordDestinationBox";
            this.ordDestinationBox.Size = new System.Drawing.Size(93, 21);
            this.ordDestinationBox.TabIndex = 42;
            // 
            // ordProductNumberLabel
            // 
            this.ordProductNumberLabel.AutoSize = true;
            this.ordProductNumberLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordProductNumberLabel.Location = new System.Drawing.Point(16, 71);
            this.ordProductNumberLabel.Name = "ordProductNumberLabel";
            this.ordProductNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.ordProductNumberLabel.TabIndex = 41;
            this.ordProductNumberLabel.Text = "제품번호";
            // 
            // ordCustomerBox
            // 
            this.ordCustomerBox.Location = new System.Drawing.Point(238, 25);
            this.ordCustomerBox.Name = "ordCustomerBox";
            this.ordCustomerBox.Size = new System.Drawing.Size(100, 21);
            this.ordCustomerBox.TabIndex = 40;
            // 
            // ordOrderCustomerLabel
            // 
            this.ordOrderCustomerLabel.AutoSize = true;
            this.ordOrderCustomerLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordOrderCustomerLabel.Location = new System.Drawing.Point(173, 28);
            this.ordOrderCustomerLabel.Name = "ordOrderCustomerLabel";
            this.ordOrderCustomerLabel.Size = new System.Drawing.Size(59, 13);
            this.ordOrderCustomerLabel.TabIndex = 39;
            this.ordOrderCustomerLabel.Text = "주문고객";
            // 
            // ordSelectBtn
            // 
            this.ordSelectBtn.Location = new System.Drawing.Point(491, 20);
            this.ordSelectBtn.Name = "ordSelectBtn";
            this.ordSelectBtn.Size = new System.Drawing.Size(154, 44);
            this.ordSelectBtn.TabIndex = 38;
            this.ordSelectBtn.Text = "SELECT";
            this.ordSelectBtn.UseVisualStyleBackColor = true;
            this.ordSelectBtn.Click += new System.EventHandler(this.ordSelectBtn_Click);
            // 
            // ordOrderNumberBox
            // 
            this.ordOrderNumberBox.Location = new System.Drawing.Point(93, 25);
            this.ordOrderNumberBox.Name = "ordOrderNumberBox";
            this.ordOrderNumberBox.Size = new System.Drawing.Size(74, 21);
            this.ordOrderNumberBox.TabIndex = 37;
            // 
            // ordOrderNumberLabel
            // 
            this.ordOrderNumberLabel.AutoSize = true;
            this.ordOrderNumberLabel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordOrderNumberLabel.Location = new System.Drawing.Point(16, 28);
            this.ordOrderNumberLabel.Name = "ordOrderNumberLabel";
            this.ordOrderNumberLabel.Size = new System.Drawing.Size(59, 13);
            this.ordOrderNumberLabel.TabIndex = 36;
            this.ordOrderNumberLabel.Text = "주문번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(278, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "~";
            // 
            // areaDB
            // 
            this.areaDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.areaDB.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.areaDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areaDB.Location = new System.Drawing.Point(0, 277);
            this.areaDB.Name = "areaDB";
            this.areaDB.RowTemplate.Height = 23;
            this.areaDB.Size = new System.Drawing.Size(722, 361);
            this.areaDB.TabIndex = 20;
            this.areaDB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.areaDB_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 62;
            this.label4.Text = "데이터 검색";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ordOrderNumberBox);
            this.panel3.Controls.Add(this.ordOrderDateComboBox);
            this.panel3.Controls.Add(this.ordOrderNumberLabel);
            this.panel3.Controls.Add(this.ordProductNumberComboBox);
            this.panel3.Controls.Add(this.ordOrderCustomerLabel);
            this.panel3.Controls.Add(this.ordQuantityBox_max);
            this.panel3.Controls.Add(this.ordCustomerBox);
            this.panel3.Controls.Add(this.ordRangeLabel);
            this.panel3.Controls.Add(this.ordProductNumberLabel);
            this.panel3.Controls.Add(this.ordDestinationBox);
            this.panel3.Controls.Add(this.ordQuantityBox_min);
            this.panel3.Controls.Add(this.ordDestinationLabel);
            this.panel3.Controls.Add(this.ordOrderDateLabel);
            this.panel3.Controls.Add(this.ordQuantityLabel);
            this.panel3.Location = new System.Drawing.Point(46, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(362, 167);
            this.panel3.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 54;
            this.label5.Text = "데이터 검색";
            // 
            // HANBIT_MART_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(722, 638);
            this.Controls.Add(this.areaDB);
            this.Controls.Add(this.ManagementTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "HANBIT_MART_Form";
            this.Text = "한빛마트 관리 프로그램";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.ManagementTab.ResumeLayout(false);
            this.customerTab.ResumeLayout(false);
            this.customerTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.productTab.ResumeLayout(false);
            this.productTab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.orderTab.ResumeLayout(false);
            this.orderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areaDB)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl ManagementTab;
        private System.Windows.Forms.TabPage customerTab;
        private System.Windows.Forms.TabPage productTab;
        private System.Windows.Forms.Button cusSelectBtn;
        private System.Windows.Forms.TextBox cusIdBox;
        private System.Windows.Forms.Label cusIDLablel;
        private System.Windows.Forms.Button cusClearBtn;
        private System.Windows.Forms.Label cusJobLabel;
        private System.Windows.Forms.Label cusGradeLabel;
        private System.Windows.Forms.TextBox cusAgeBox;
        private System.Windows.Forms.Label cusAgeLabel;
        private System.Windows.Forms.TextBox cusNameBox;
        private System.Windows.Forms.Label cusNameLabel;
        private System.Windows.Forms.TextBox cusAccumulationBox_min;
        private System.Windows.Forms.Label cusAccumulationLabel;
        private System.Windows.Forms.Button cusOthersBtn;
        private System.Windows.Forms.TextBox cusAccumulationBox_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cusGradeComboBox;
        private System.Windows.Forms.ComboBox cusJobComboBox;
        private System.Windows.Forms.ComboBox proProductNumberComboBox;
        private System.Windows.Forms.ComboBox proManufacturerComboBox;
        private System.Windows.Forms.TextBox proPriceBox_max;
        private System.Windows.Forms.Label proRangeLabel2;
        private System.Windows.Forms.Button proOthersBtn;
        private System.Windows.Forms.TextBox proPriceBox_min;
        private System.Windows.Forms.Button proClearBtn;
        private System.Windows.Forms.Label proPriceLabel;
        private System.Windows.Forms.Label proManufacturerLabel;
        private System.Windows.Forms.TextBox proStockBox_min;
        private System.Windows.Forms.Label proStockLabel;
        private System.Windows.Forms.TextBox proProductNameBox;
        private System.Windows.Forms.Label proProductNameLabel;
        private System.Windows.Forms.Button proSelectBtn;
        private System.Windows.Forms.Label proProductNumberLabel;
        private System.Windows.Forms.TextBox proStockBox_max;
        private System.Windows.Forms.Label proRangeLabel;
        private System.Windows.Forms.Label cusRangeLabel;
        private System.Windows.Forms.DataGridView areaDB;
        private System.Windows.Forms.TabPage orderTab;
        private System.Windows.Forms.ComboBox ordOrderDateComboBox;
        private System.Windows.Forms.ComboBox ordProductNumberComboBox;
        private System.Windows.Forms.TextBox ordQuantityBox_max;
        private System.Windows.Forms.Label ordRangeLabel;
        private System.Windows.Forms.Button ordOthersBtn;
        private System.Windows.Forms.TextBox ordQuantityBox_min;
        private System.Windows.Forms.Label ordOrderDateLabel;
        private System.Windows.Forms.Button ordClearBtn;
        private System.Windows.Forms.Label ordQuantityLabel;
        private System.Windows.Forms.Label ordDestinationLabel;
        private System.Windows.Forms.TextBox ordDestinationBox;
        private System.Windows.Forms.Label ordProductNumberLabel;
        private System.Windows.Forms.TextBox ordCustomerBox;
        private System.Windows.Forms.Label ordOrderCustomerLabel;
        private System.Windows.Forms.Button ordSelectBtn;
        private System.Windows.Forms.TextBox ordOrderNumberBox;
        private System.Windows.Forms.Label ordOrderNumberLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}

