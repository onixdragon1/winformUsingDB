using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanbitMart_WinFormUsingDB
{
    public partial class Form2 : Form
    {
        #region 고객 테이블 변수
        // 문자열 데이터를 가진 고객아이디, 고객이름, 등급, 직업을 받아올 변수
        private string cusId, cusName, cusGrade, cusJob;
        // 숫자 데이터를 가진 나이, 적립금을 받아올 변수
        // 데이터 전달 시 string으로 전달, 받아서 화면에는 int로 뿌림
        private string cusAge, cusAccu;
        #endregion

        #region 제품 테이블 변수
        // 문자열 데이터를 가진 제품번호, 제품명, 제조업체를 받아올 변수
        private string proNum, proName, proManu;
        // 숫자 데이터를 가진 재고량, 단가를 받아올 변수
        // 데이터 전달 시 string으로 전달, 받아서 화면에는 int로 뿌림
        private string proStock, proPrice;
        #endregion

        #region 주문 테이블 변수
        // 문자열 데이터를 가진 주문번호, 주문고객, 제품번호, 배송지, 주문일자를 받아올 변수
        private string ordOrderNum, ordCus, ordProductNum, ordDest, ordDate;
        // 숫자 데이터를 가진 수량을 받아올 변수
        // 데이터 전달 시 string으로 전달, 받아서 화면에는 int로 뿌림
        private string ordQuantity;
        #endregion

        private string NameOfSelectedTab;
        private int IndexOfSelectedRow;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string NameOfSelectedTab)
        {
            InitializeComponent();
            this.NameOfSelectedTab = NameOfSelectedTab;
        }

        // 고객 & 주문 테이블 생성자
        // parameter의 개수(테이블의 컬럼 개수)가 같아 오버라이딩하지 못하고 if 처리
        public Form2(int IndexOfSelectedRow, string NameOfSelectedTab, string value1, string value2, string value3, string value4, string value5, string value6)
        {
            InitializeComponent();
            this.IndexOfSelectedRow = IndexOfSelectedRow;
            this.NameOfSelectedTab = NameOfSelectedTab;
            if (NameOfSelectedTab == "고객")
            {
                this.cusId = value1;
                this.cusName = value2;
                this.cusAge = value3;
                this.cusGrade = value4;
                this.cusJob = value5;
                this.cusAccu = value6;
            }
            else if (NameOfSelectedTab == "주문")
            {
                this.ordOrderNum = value1;
                this.ordCus = value2;
                this.ordProductNum = value3;
                this.ordQuantity = value4;
                this.ordDest = value5;
                this.ordDate = value6;
            }
        }

        // 제품 테이블 생성자
        // 고객 & 주문 테이블과는 parameter의 개수가 달라 오버라이딩 (재정의)
        public Form2(int IndexOfSelectedRow, string NameOfSelectedTab, string proNum, string proName, string proStock, string proPrice, string proManu)
        {
            InitializeComponent();
            this.IndexOfSelectedRow = IndexOfSelectedRow;
            this.NameOfSelectedTab = NameOfSelectedTab;
            this.proNum = proNum;
            this.proName = proName;
            this.proStock = proStock;
            this.proPrice = proPrice;
            this.proManu = proManu;
        }

        HANBIT_MART_Form mainForm;
        private void Form2_Load(object sender, EventArgs e)
        {
            // 어떤 테이블에서 기타 쿼리를 사용하고자 하는 요청이 있는지
            // NameOfSelectedTab이라는 변수로 구분하여 form2를 초기화
            if(NameOfSelectedTab == "고객")
            {
                OtherQueryLabel.Text += NameOfSelectedTab + " Table";
                value1Label.Text = "고객아이디";
                value1TextBox.Text = cusId;
                value2Label.Text = "고객이름";
                value2TextBox.Text = cusName;
                value3Label.Text = "나이";
                value3TextBox.Text = cusAge;
                value4Label.Text = "등급";
                value4TextBox.Text = cusGrade;
                value5Label.Text = "직업";
                value5TextBox.Text = cusJob;
                value6Label.Text = "적립금";
                value6TextBox.Text = cusAccu;
            }
            else if(NameOfSelectedTab == "제품")
            {
                OtherQueryLabel.Text += NameOfSelectedTab + " Table";
                value1Label.Text = "제품번호";
                value1TextBox.Text = proNum;
                value2Label.Text = "제품명";
                value2TextBox.Text = proName;
                value3Label.Text = "재고량";
                value3TextBox.Text = proStock;
                value4Label.Text = "단가";
                value4TextBox.Text = proPrice;
                value5Label.Text = "제조업체";
                value5TextBox.Text = proManu;
                value6Label.Hide();
                value6TextBox.Hide();
            }
            else if (NameOfSelectedTab == "주문")
            {
                OtherQueryLabel.Text += NameOfSelectedTab + " Table";
                value1Label.Text = "주문번호";
                value1TextBox.Text = ordOrderNum;
                value2Label.Text = "주문고객";
                value2TextBox.Text = ordCus;
                value3Label.Text = "제품번호";
                value3TextBox.Text = ordProductNum;
                value4Label.Text = "수량";
                value4TextBox.Text = ordQuantity;
                value5Label.Text = "배송지";
                value5TextBox.Text = ordDest;
                value6Label.Text = "주문일자";
                value6TextBox.Text = ordDate;
            }

            if(Owner != null)
            {
                mainForm = Owner as HANBIT_MART_Form;
            }
        }

        // Form2의 텍스트박스가 비어있는지 확인하는 함수
        // 비어있다면 이전의 데이터를 받아와서 삽입, 수정할 시 데이터 손실 방지
        public string[] IfTextBoxIsBlank(string[] data, string currentTab)
        {
            if(currentTab == "고객")
            {
                if (data[0] == "") data[0] = cusId;
                if (data[1] == "") data[1] = cusName;
                if (data[2] == "") data[2] = cusAge;
                if (data[3] == "") data[3] = cusGrade;
                if (data[4] == "") data[4] = cusJob;
                if (data[5] == "") data[5] = cusAccu;
            }
            else if (currentTab == "제품")
            {
                if (data[0] == "") data[0] = proNum;
                if (data[1] == "") data[1] = proName;
                if (data[2] == "") data[2] = proStock;
                if (data[3] == "") data[3] = proPrice;
                if (data[4] == "") data[4] = proManu;
            }
            else if (currentTab == "주문")
            {
                if (data[0] == "") data[0] = ordOrderNum;
                if (data[1] == "") data[1] = ordCus;
                if (data[2] == "") data[2] = ordProductNum;
                if (data[3] == "") data[3] = ordQuantity;
                if (data[4] == "") data[4] = ordDest;
                if (data[5] == "") data[5] = ordDate;
            }
            return data;
        }

        // Form2에서 Insert 버튼을 눌렀을 경우
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (NameOfSelectedTab == "고객")
            {
                string[] rowDatas = {
                    value1TextBox.Text,
                    value2TextBox.Text,
                    value3TextBox.Text,
                    value4TextBox.Text,
                    value5TextBox.Text,
                    value6TextBox.Text,
                };

                mainForm.InsertRow(rowDatas, NameOfSelectedTab);
                this.Close();
            }
            else if (NameOfSelectedTab == "제품")
            {
                string[] rowDatas = {
                    value1TextBox.Text,
                    value2TextBox.Text,
                    value3TextBox.Text,
                    value4TextBox.Text,
                    value5TextBox.Text,
                };
                mainForm.InsertRow(rowDatas, NameOfSelectedTab);
                this.Close();
            }
            else if (NameOfSelectedTab == "주문")
            {
                string[] rowDatas = {
                    value1TextBox.Text,
                    value2TextBox.Text,
                    value3TextBox.Text,
                    value4TextBox.Text,
                    value5TextBox.Text,
                    value6TextBox.Text,
                };

                mainForm.InsertRow(rowDatas, NameOfSelectedTab);
                this.Close();
            }
        }

        // Form2에서 Update 버튼을 눌렀을 경우
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (NameOfSelectedTab == "고객")
            {
                string[] rowDatas = {
                    value1TextBox.Text,
                    value2TextBox.Text,
                    value3TextBox.Text,
                    value4TextBox.Text,
                    value5TextBox.Text,
                    value6TextBox.Text,
                };

                mainForm.UpdateRow(IfTextBoxIsBlank(rowDatas, NameOfSelectedTab), NameOfSelectedTab);
                this.Close();
            }
            else if (NameOfSelectedTab == "제품")
            {
                string[] rowDatas = {
                    value1TextBox.Text,
                    value2TextBox.Text,
                    value3TextBox.Text,
                    value4TextBox.Text,
                    value5TextBox.Text,
                };

                mainForm.UpdateRow(IfTextBoxIsBlank(rowDatas, NameOfSelectedTab), NameOfSelectedTab);
                this.Close();
            }
            else if(NameOfSelectedTab == "주문")
            {
                string[] rowDatas = {
                    value1TextBox.Text,
                    value2TextBox.Text,
                    value3TextBox.Text,
                    value4TextBox.Text,
                    value5TextBox.Text,
                    value6TextBox.Text,
                };

                mainForm.UpdateRow(IfTextBoxIsBlank(rowDatas, NameOfSelectedTab), NameOfSelectedTab);
                this.Close();
            }
        }

        // Form2에서 Delete 버튼을 눌렀을 경우
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(NameOfSelectedTab == "고객")
                mainForm.DeleteRow(cusId, NameOfSelectedTab);
            else if (NameOfSelectedTab == "제품")
                mainForm.DeleteRow(proNum, NameOfSelectedTab);
            else if (NameOfSelectedTab == "주문")
                mainForm.DeleteRow(ordOrderNum, NameOfSelectedTab);
            this.Close();
        }
    }
}
