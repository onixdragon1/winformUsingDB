using MySql.Data.MySqlClient;
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
    public partial class HANBIT_MART_Form : Form
    {
        public HANBIT_MART_Form()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter adapter, adapter2, adapter3;
        DataSet dataSet;
        int IndexOfSelectedRow;
        string NameOfSelectedTab;

        string[] Tables = { "고객", "제품", "주문" };

        private void Form1_Load(object sender, EventArgs e)
        {
            // 각 테이블에 담긴 초기 데이터를 각 테이블에 맞는 DataView에 뿌리고
            // 뿌려진 데이터 중 특정 컬럼들을 콤보박스에 세팅
            string connectionString = "server=localhost;port=3306;database=HanbitMart;uid=root;pwd=angleeha77@@A";
            conn = new MySqlConnection(connectionString);
            dataSet = new DataSet();

            adapter = new MySqlDataAdapter("SELECT * FROM 고객", conn);
            adapter.Fill(dataSet, "고객");

            adapter2 = new MySqlDataAdapter("SELECT * FROM 제품", conn);
            adapter2.Fill(dataSet, "제품");

            adapter3 = new MySqlDataAdapter("SELECT * FROM 주문", conn);
            adapter3.Fill(dataSet, "주문");
            
            areaDB.DataSource = dataSet.Tables["고객"]; 
            //areaDB.DataSource = dataSet.Tables["제품"];
            //areaDB.DataSource = dataSet.Tables["주문"];
            
            Setting("고객"); Setting("제품"); Setting("주문");
        }

        /*public void sort_Table(string currentTab)
        {
            if (NameOfSelectedTab == "고객")
            {
                areaDB.Columns["고객아이디"].DisplayIndex = 0;
                areaDB.Columns["고객이름"].DisplayIndex = 1;
                areaDB.Columns["나이"].DisplayIndex = 2;
                areaDB.Columns["등급"].DisplayIndex = 3;
                areaDB.Columns["직업"].DisplayIndex = 4;
                areaDB.Columns["적립금"].DisplayIndex = 5;
            }
            else if (NameOfSelectedTab == "제품")
            {
                areaDB.Columns["제품번호"].DisplayIndex = 0;
                areaDB.Columns["제품명"].DisplayIndex = 1;
                areaDB.Columns["재고량"].DisplayIndex = 2;
                areaDB.Columns["단가"].DisplayIndex = 3;
                areaDB.Columns["제조업체"].DisplayIndex = 4;
            }
            else if (NameOfSelectedTab == "주문")
            {
                areaDB.Columns["주문번호"].DisplayIndex = 0;
                areaDB.Columns["주문고객"].DisplayIndex = 1;
                areaDB.Columns["제품번호"].DisplayIndex = 2;
                areaDB.Columns["수량"].DisplayIndex = 3;
                areaDB.Columns["배송지"].DisplayIndex = 4;
                areaDB.Columns["주문일자"].DisplayIndex = 5;
            }
        }*/

        private void ManagementTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameOfSelectedTab = ManagementTab.SelectedTab.Text;
            if (NameOfSelectedTab == "고객")
            {
                dataSet.Tables[NameOfSelectedTab].Clear();  // 선택한 테이블의 이전 데이터 지우기
                adapter.Fill(dataSet, NameOfSelectedTab);
            }
            else if (NameOfSelectedTab == "제품")
            {
                dataSet.Tables[NameOfSelectedTab].Clear();   // 선택한 테이블의 이전 데이터 지우기
                adapter2.Fill(dataSet, NameOfSelectedTab);
            }
            else if (NameOfSelectedTab == "주문")
            {
                dataSet.Tables[NameOfSelectedTab].Clear();   // 선택한 테이블의 이전 데이터 지우기
                adapter3.Fill(dataSet, NameOfSelectedTab);
            }
            for (int i = 0; i < Tables.Length; i++)
            {
                if(NameOfSelectedTab == Tables[i].ToString())
                    areaDB.DataSource = dataSet.Tables[NameOfSelectedTab];
            }
            if (NameOfSelectedTab == "주문")
            {
                areaDB.Columns["주문번호"].DisplayIndex = 0;
                areaDB.Columns["주문고객"].DisplayIndex = 1;
                areaDB.Columns["제품번호"].DisplayIndex = 2;
            }
            //sort_Table(NameOfSelectedTab);
        }

        private void Setting(string currentTab)
        {
            try
            {
                if (currentTab == "고객")
                {
                    string queryStr = "SELECT distinct 직업 FROM " + currentTab;
                    MySqlCommand commands = new MySqlCommand(queryStr, conn);

                    conn.Open();
                    MySqlDataReader reader = commands.ExecuteReader();
                    while (reader.Read())
                    {
                        cusJobComboBox.Items.Add(reader.GetString("직업"));
                    }
                    reader.Close();

                    queryStr = "SELECT distinct 등급 FROM " + currentTab;
                    commands = new MySqlCommand(queryStr, conn);
                    reader = commands.ExecuteReader();
                    while (reader.Read())
                    {
                        cusGradeComboBox.Items.Add(reader.GetString("등급"));
                    }
                    reader.Close();
                }
                else if(currentTab == "제품")
                {
                    string queryStr = "SELECT distinct 제품번호 FROM " + currentTab;
                    MySqlCommand commands = new MySqlCommand(queryStr, conn);

                    conn.Open();
                    MySqlDataReader reader = commands.ExecuteReader();
                    while (reader.Read())
                    {
                        proProductNumberComboBox.Items.Add(reader.GetString("제품번호"));
                    }
                    reader.Close();

                    queryStr = "SELECT distinct 제조업체 FROM " + currentTab;
                    commands = new MySqlCommand(queryStr, conn);
                    reader = commands.ExecuteReader();
                    while (reader.Read())
                    {
                        proManufacturerComboBox.Items.Add(reader.GetString("제조업체"));
                    }
                    reader.Close();
                }
                else
                {
                    string queryStr = "SELECT distinct 제품번호 FROM " + currentTab;
                    MySqlCommand commands = new MySqlCommand(queryStr, conn);

                    conn.Open();
                    MySqlDataReader reader = commands.ExecuteReader();
                    while (reader.Read())
                    {
                        ordProductNumberComboBox.Items.Add(reader.GetString("제품번호"));
                    }
                    reader.Close();

                    queryStr = "SELECT distinct 주문일자 FROM " + currentTab;
                    commands = new MySqlCommand(queryStr, conn);
                    reader = commands.ExecuteReader();
                    while (reader.Read())
                    {
                        ordOrderDateComboBox.Items.Add(reader.GetString("주문일자"));
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ComboBox_ReSetting(string currentTab)
        {
            if (currentTab == "고객")
            {
                cusJobComboBox.Items.Clear();
                cusGradeComboBox.Items.Clear();
                Setting(currentTab);
            }
            else if (currentTab == "제품")
            {
                proProductNumberComboBox.Items.Clear();
                proManufacturerComboBox.Items.Clear();
                Setting(currentTab);
            }
            else if (currentTab == "주문")
            {
                ordOrderDateComboBox.Items.Clear();
                ordProductNumberComboBox.Items.Clear();
                Setting(currentTab);
            }
        }

        private void cusSelectBtn_Click(object sender, EventArgs e)
        {
            string queryString;

            string[] options = new string[6];
            options[0] = (cusIdBox.Text != "") ? "고객아이디=@고객아이디" : null;
            options[1] = (cusNameBox.Text != "") ? "고객이름=@고객이름" : null;
            options[2] = (cusAgeBox.Text != "") ? "나이=@나이" : null;
            options[3] = (cusJobComboBox.Text != "") ? "직업=@직업" : null;
            options[4] = (cusGradeComboBox.Text != "") ? "등급=@등급" : null;
            string options_Accumulation;
            if (cusAccumulationBox_min.Text != "" && cusAccumulationBox_max.Text != "")
            {
                options_Accumulation = "적립금>=@Accumulation_min and 적립금<=@Accumulation_max";
            }
            else if (cusAccumulationBox_min.Text != "" || cusAccumulationBox_max.Text != "")
            {
                if (cusAccumulationBox_min.Text != "")
                    options_Accumulation = "적립금>=@Accumulation_min";
                else options_Accumulation = "적립금<=@Accumulation_max";
            }
            else
            {
                options_Accumulation = null;
            }
            options[5] = options_Accumulation;

            if (options[0] != null || options[1] != null || options[2] != null || options[3] != null || options[4] != null || options[5] != null)
            {
                queryString = $"SELECT * FROM 고객 WHERE ";
                bool firstOption = true;
                for (int i = 0; i < options.Length; i++)
                {
                    if (options[i] != null)
                    {
                        if (firstOption)
                        {
                            queryString += options[i];
                            firstOption = false;
                        }
                        else queryString += " and " + options[i];
                    }
                }
            }
            else queryString = "SELECT * FROM 고객";

            adapter.SelectCommand = new MySqlCommand(queryString, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@고객아이디", cusIdBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@고객이름", cusNameBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@나이", cusAgeBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@직업", cusJobComboBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@등급", cusGradeComboBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Accumulation_min", cusAccumulationBox_min.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Accumulation_max", cusAccumulationBox_max.Text);

            try
            {
                conn.Open();
                dataSet.Tables["고객"].Clear();
                if (adapter.Fill(dataSet, "고객") > 0)
                    areaDB.DataSource = dataSet.Tables["고객"];
                else MessageBox.Show("찾는 데이터가 엄서용!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void proSelectBtn_Click(object sender, EventArgs e)
        {
            string queryString;

            string[] options = new string[5];
            options[0] = (proProductNumberComboBox.Text != "") ? "제품번호=@제품번호" : null;
            options[1] = (proProductNameBox.Text != "") ? "제품명=@제품명" : null;
            string options_Stock;
            if (proStockBox_min.Text != "" && proStockBox_max.Text != "")
                options_Stock = "재고량>=@Stock_min and 재고량<=@Stock_max";
            else if (proStockBox_min.Text != "" || proStockBox_max.Text != "")
            {
                if (proStockBox_min.Text != "")
                    options_Stock = "재고량>=@Price_min";
                else options_Stock = "재고량<=@Price_max";
            }
            else 
                options_Stock = null;
            options[2] = options_Stock;
            string options_Price;
            if (proPriceBox_min.Text != "" && proPriceBox_max.Text != "")
                options_Price = "단가>=@Price_min and 단가<=@Price_max";
            else if (proPriceBox_min.Text != "" || proPriceBox_max.Text != "")
            {
                if (proPriceBox_min.Text != "")
                    options_Price = "단가>=@Price_min";
                else options_Price = "단가<=@Price_max";
            }
            else
                options_Price = null;
            options[3] = options_Price;
            options[4] = (proManufacturerComboBox.Text != "") ? "제조업체=@제조업체" : null;

            if (options[0] != null || options[1] != null || options[2] != null || options[3] != null || options[4] != null)
            {
                queryString = $"SELECT * FROM 제품 WHERE ";
                bool firstOption = true;
                for (int i = 0; i < options.Length; i++)
                {
                    if (options[i] != null)
                    {
                        if (firstOption)
                        {
                            queryString += options[i];
                            firstOption = false;
                        }
                        else queryString += " and " + options[i];
                    }
                }
            }
            else queryString = "SELECT * FROM 제품";

            adapter2.SelectCommand = new MySqlCommand(queryString, conn);
            adapter2.SelectCommand.Parameters.AddWithValue("@제품번호", proProductNumberComboBox.Text);
            adapter2.SelectCommand.Parameters.AddWithValue("@제품명", proProductNameBox.Text);
            adapter2.SelectCommand.Parameters.AddWithValue("@Stock_min", proStockBox_min.Text);
            adapter2.SelectCommand.Parameters.AddWithValue("@Stock_max", proStockBox_max.Text);
            adapter2.SelectCommand.Parameters.AddWithValue("@제조업체", proManufacturerComboBox.Text);
            adapter2.SelectCommand.Parameters.AddWithValue("@Price_min", proPriceBox_min.Text);
            adapter2.SelectCommand.Parameters.AddWithValue("@Price_max", proPriceBox_max.Text);

            try
            {
                conn.Open();
                dataSet.Tables["제품"].Clear();
                if (adapter2.Fill(dataSet, "제품") > 0)
                    areaDB.DataSource = dataSet.Tables["제품"];
                else MessageBox.Show("찾는 데이터가 엄서용!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ordSelectBtn_Click(object sender, EventArgs e)
        {
            string queryString;

            string[] options = new string[6];
            options[0] = (ordOrderNumberBox.Text != "") ? "주문번호=@주문번호" : null;
            options[1] = (ordCustomerBox.Text != "") ? "주문고객=@주문고객" : null;
            options[2] = (ordProductNumberComboBox.Text != "") ? "제품번호=@제품번호" : null;
            string options_Quantity;
            if (ordQuantityBox_min.Text != "" && ordQuantityBox_max.Text != "")
            {
                options_Quantity = "수량>=@Quantity_min and 수량<=@Quantity_max";
            }
            else if (ordQuantityBox_min.Text != "" || ordQuantityBox_max.Text != "")
            {
                if (ordQuantityBox_min.Text != "")
                    options_Quantity = "수량>=@Quantity_min";
                else options_Quantity = "수량<=@Quantity_max";
            }
            else
            {
                options_Quantity = null;
            }
            options[3] = options_Quantity;
            options[4] = (ordDestinationBox.Text != "") ? "배송지=@배송지" : null;
            options[5] = (ordOrderDateComboBox.Text != "") ? "주문일자=@주문일자" : null;

            if (options[0] != null || options[1] != null || options[2] != null || options[3] != null || options[4] != null || options[5] != null)
            {
                queryString = $"SELECT * FROM 주문 WHERE ";
                bool firstOption = true;
                for (int i = 0; i < options.Length; i++)
                {
                    if (options[i] != null)
                    {
                        if (firstOption)
                        {
                            queryString += options[i];
                            firstOption = false;
                        }
                        else queryString += " and " + options[i];
                    }
                }
            }
            else queryString = "SELECT * FROM 주문";

            adapter3.SelectCommand = new MySqlCommand(queryString, conn);
            adapter3.SelectCommand.Parameters.AddWithValue("@주문번호", ordOrderNumberBox.Text);
            adapter3.SelectCommand.Parameters.AddWithValue("@주문고객", ordCustomerBox.Text);
            adapter3.SelectCommand.Parameters.AddWithValue("@제품번호", ordProductNumberComboBox.Text);
            adapter3.SelectCommand.Parameters.AddWithValue("@배송지", ordDestinationBox.Text);
            adapter3.SelectCommand.Parameters.AddWithValue("@주문일자", ordOrderDateComboBox.Text);
            adapter3.SelectCommand.Parameters.AddWithValue("@Quantity_min", ordQuantityBox_min.Text);
            adapter3.SelectCommand.Parameters.AddWithValue("@Quantity_max", ordQuantityBox_max.Text);

            try
            {
                conn.Open();
                dataSet.Tables["주문"].Clear();
                if (adapter3.Fill(dataSet, "주문") > 0)
                    areaDB.DataSource = dataSet.Tables["주문"];
                else MessageBox.Show("찾는 데이터가 엄서용!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void InsertRow(string[] rowDatas, string NameOfSelectedTab) 
        {
            string queryString;
            if (NameOfSelectedTab == "고객")
            {
                // INSERT 쿼리 사용을 위해 선언하고 데이터 타입 지정
                queryString = "INSERT INTO 고객 VALUES(@고객아이디, @고객이름, @나이, @등급, @직업, @적립금)";
                adapter.InsertCommand = new MySqlCommand(queryString, conn);
                adapter.InsertCommand.Parameters.Add("@고객아이디", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@고객이름", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@나이", MySqlDbType.Int32);
                adapter.InsertCommand.Parameters.Add("@등급", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@직업", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@적립금", MySqlDbType.Int32);

                #region Parameters를 이용한 데이터 삽입 처리
                adapter.InsertCommand.Parameters["@고객아이디"].Value = rowDatas[0];
                adapter.InsertCommand.Parameters["@고객이름"].Value = rowDatas[1];
                adapter.InsertCommand.Parameters["@나이"].Value = Convert.ToInt32(rowDatas[2]);
                adapter.InsertCommand.Parameters["@등급"].Value = rowDatas[3];
                adapter.InsertCommand.Parameters["@직업"].Value = rowDatas[4];
                adapter.InsertCommand.Parameters["@적립금"].Value = Convert.ToInt32(rowDatas[5]);
                #endregion
            }
            else if (NameOfSelectedTab == "제품")
            {
                // INSERT 쿼리 사용을 위해 선언하고 데이터 타입 지정
                queryString = "INSERT INTO 제품 VALUES(@제품번호, @제품명, @재고량, @단가, @제조업체)";
                adapter2.InsertCommand = new MySqlCommand(queryString, conn);
                adapter2.InsertCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);
                adapter2.InsertCommand.Parameters.Add("@제품명", MySqlDbType.VarChar);
                adapter2.InsertCommand.Parameters.Add("@재고량", MySqlDbType.Int32);
                adapter2.InsertCommand.Parameters.Add("@단가", MySqlDbType.Int32);
                adapter2.InsertCommand.Parameters.Add("@제조업체", MySqlDbType.VarChar);

                #region Parameters를 이용한 데이터 삽입 처리
                adapter2.InsertCommand.Parameters["@제품번호"].Value = rowDatas[0];
                adapter2.InsertCommand.Parameters["@제품명"].Value = rowDatas[1];
                adapter2.InsertCommand.Parameters["@재고량"].Value = Convert.ToInt32(rowDatas[2]);
                adapter2.InsertCommand.Parameters["@단가"].Value = Convert.ToInt32(rowDatas[3]);
                adapter2.InsertCommand.Parameters["@제조업체"].Value = rowDatas[4];
                #endregion
            }
            else if (NameOfSelectedTab == "주문")
            {
                // INSERT 쿼리 사용을 위해 선언하고 데이터 타입 지정
                queryString = "INSERT INTO 주문 VALUES(@주문번호, @주문고객, @제품번호, @수량, @배송지, @주문일자)";
                adapter3.InsertCommand = new MySqlCommand(queryString, conn);
                adapter3.InsertCommand.Parameters.Add("@주문번호", MySqlDbType.VarChar);
                adapter3.InsertCommand.Parameters.Add("@주문고객", MySqlDbType.VarChar);
                adapter3.InsertCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);
                adapter3.InsertCommand.Parameters.Add("@수량", MySqlDbType.Int32);
                adapter3.InsertCommand.Parameters.Add("@배송지", MySqlDbType.VarChar);
                adapter3.InsertCommand.Parameters.Add("@주문일자", MySqlDbType.Date);

                #region Parameters를 이용한 데이터 삽입 처리
                adapter3.InsertCommand.Parameters["@주문번호"].Value = rowDatas[0];
                adapter3.InsertCommand.Parameters["@주문고객"].Value = rowDatas[1];
                adapter3.InsertCommand.Parameters["@제품번호"].Value = rowDatas[2];
                adapter3.InsertCommand.Parameters["@수량"].Value = Convert.ToInt32(rowDatas[3]);
                adapter3.InsertCommand.Parameters["@배송지"].Value = rowDatas[4];
                adapter3.InsertCommand.Parameters["@주문일자"].Value = rowDatas[5];
                #endregion
            }
            try
            {
                conn.Open();
                if (NameOfSelectedTab == "고객")
                {
                    adapter.InsertCommand.ExecuteNonQuery();

                    dataSet.Tables[NameOfSelectedTab].Clear();  // 선택한 테이블의 이전 데이터 지우기
                    adapter.Fill(dataSet, NameOfSelectedTab);
                }
                else if (NameOfSelectedTab == "제품")
                {
                    adapter2.InsertCommand.ExecuteNonQuery();

                    dataSet.Tables[NameOfSelectedTab].Clear();   // 선택한 테이블의 이전 데이터 지우기
                    adapter2.Fill(dataSet, NameOfSelectedTab);
                }
                else if (NameOfSelectedTab == "주문")
                {
                    adapter3.InsertCommand.ExecuteNonQuery();

                    dataSet.Tables[NameOfSelectedTab].Clear();   // 선택한 테이블의 이전 데이터 지우기
                    adapter3.Fill(dataSet, NameOfSelectedTab);
                }

                for (int i = 0; i < Tables.Length; i++)
                {
                    if (NameOfSelectedTab == Tables[i].ToString())
                    {
                        areaDB.DataSource = dataSet.Tables[NameOfSelectedTab];
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            // 만약 특정 컬럼에 새로운 데이터가 들어온 경우 ComboBox 갱신
            // ex) "고객" 테이블의 "직업" 컬럼에 현재 들어있는 6개의 직업 외
            // 다른 직업의 이름이 입력되었을 경우 삭제한다.
            ComboBox_ReSetting(NameOfSelectedTab);
        }

        public void UpdateRow(string[] rowDatas, string NameOfSelectedTab)
        {
            string queryString;
            if (NameOfSelectedTab == "고객")
            {
                queryString = "UPDATE 고객 SET 고객이름=@고객이름, 나이=@나이, 등급=@등급, 직업=@직업, 적립금=@적립금 WHERE 고객아이디=@고객아이디";
                adapter.UpdateCommand = new MySqlCommand(queryString, conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@고객아이디", rowDatas[0]);
                adapter.UpdateCommand.Parameters.AddWithValue("@고객이름", rowDatas[1]);
                adapter.UpdateCommand.Parameters.AddWithValue("@나이", rowDatas[2]);
                adapter.UpdateCommand.Parameters.AddWithValue("@등급", rowDatas[3]);
                adapter.UpdateCommand.Parameters.AddWithValue("@직업", rowDatas[4]);
                adapter.UpdateCommand.Parameters.AddWithValue("@적립금", rowDatas[5]);
            }
            else if (NameOfSelectedTab == "제품")
            {
                queryString = "UPDATE 제품 SET 제품명=@제품명, 재고량=@재고량, 단가=@단가, 제조업체=@제조업체 WHERE 제품번호=@제품번호";
                adapter2.UpdateCommand = new MySqlCommand(queryString, conn);
                adapter2.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDatas[0]);
                adapter2.UpdateCommand.Parameters.AddWithValue("@제품명", rowDatas[1]);
                adapter2.UpdateCommand.Parameters.AddWithValue("@재고량", rowDatas[2]);
                adapter2.UpdateCommand.Parameters.AddWithValue("@단가", rowDatas[3]);
                adapter2.UpdateCommand.Parameters.AddWithValue("@제조업체", rowDatas[4]);
            }
            else if (NameOfSelectedTab == "주문")
            {
                queryString = "UPDATE 주문 SET 주문고객=@주문고객, 제품번호=@제품번호, 수량=@수량, 배송지=@배송지, 주문일자=@주문일자 WHERE 주문번호=@주문번호";
                adapter3.UpdateCommand = new MySqlCommand(queryString, conn);
                adapter3.UpdateCommand.Parameters.AddWithValue("@주문번호", rowDatas[0]);
                adapter3.UpdateCommand.Parameters.AddWithValue("@주문고객", rowDatas[1]);
                adapter3.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDatas[2]);
                adapter3.UpdateCommand.Parameters.AddWithValue("@수량", rowDatas[3]);
                adapter3.UpdateCommand.Parameters.AddWithValue("@배송지", rowDatas[4]);
                adapter3.UpdateCommand.Parameters.AddWithValue("@주문일자", rowDatas[5]);
            }
            try
            {
                conn.Open();
                if (NameOfSelectedTab == "고객")
                {
                    adapter.UpdateCommand.ExecuteNonQuery();

                    dataSet.Tables[NameOfSelectedTab].Clear();   // 선택한 테이블의 이전 데이터 지우기
                    adapter.Fill(dataSet, NameOfSelectedTab);
                }
                else if (NameOfSelectedTab == "제품")
                {
                    adapter2.UpdateCommand.ExecuteNonQuery();

                    dataSet.Tables[NameOfSelectedTab].Clear();   // 선택한 테이블의 이전 데이터 지우기
                    adapter2.Fill(dataSet, NameOfSelectedTab);
                }
                else if (NameOfSelectedTab == "주문")
                {
                    adapter3.UpdateCommand.ExecuteNonQuery();

                    dataSet.Tables[NameOfSelectedTab].Clear();   // 선택한 테이블의 이전 데이터 지우기
                    adapter3.Fill(dataSet, NameOfSelectedTab);
                }

                for (int i = 0; i < Tables.Length; i++)
                {
                    if (NameOfSelectedTab == Tables[i].ToString())
                        areaDB.DataSource = dataSet.Tables[NameOfSelectedTab];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            ComboBox_ReSetting(NameOfSelectedTab);
        }

        public void DeleteRow(string PrimaryKey, string NameOfSelectedTab)
        {
            string queryString;
            if(NameOfSelectedTab == "고객")
            {
                queryString = "DELETE FROM 고객 WHERE 고객아이디=@고객아이디";
                adapter.DeleteCommand = new MySqlCommand(queryString, conn);
                adapter.DeleteCommand.Parameters.AddWithValue("@고객아이디", PrimaryKey);
            }
            else if (NameOfSelectedTab == "제품")
            {
                queryString = "DELETE FROM 제품 WHERE 제품번호=@제품번호";
                adapter2.DeleteCommand = new MySqlCommand(queryString, conn);
                adapter2.DeleteCommand.Parameters.AddWithValue("@제품번호", PrimaryKey);
            }
            else if (NameOfSelectedTab == "주문")
            {
                queryString = "DELETE FROM 주문 WHERE 주문번호=@주문번호";
                adapter3.DeleteCommand = new MySqlCommand(queryString, conn);
                adapter3.DeleteCommand.Parameters.AddWithValue("@주문번호", PrimaryKey);
            }
            try
            {
                conn.Open();
                if (NameOfSelectedTab == "고객")
                {
                    adapter.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();  // 선택한 테이블의 이전 데이터 지우기
                    adapter.Fill(dataSet, NameOfSelectedTab);
                }
                else if (NameOfSelectedTab == "제품")
                {
                    adapter2.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();  // 선택한 테이블의 이전 데이터 지우기
                    adapter2.Fill(dataSet, NameOfSelectedTab);
                }
                else if (NameOfSelectedTab == "주문")
                {
                    adapter3.DeleteCommand.ExecuteNonQuery();

                    dataSet.Clear();  // 선택한 테이블의 이전 데이터 지우기
                    adapter3.Fill(dataSet, NameOfSelectedTab);
                }

                for (int i = 0; i < Tables.Length; i++)
                {
                    if (NameOfSelectedTab == Tables[i].ToString())
                        areaDB.DataSource = dataSet.Tables[NameOfSelectedTab];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            ComboBox_ReSetting(NameOfSelectedTab);
        }

        private void cusOthersBtn_Click(object sender, EventArgs e)
        {
            
            Form2 modalForm = new Form2("고객");
            modalForm.Owner = this;
            modalForm.ShowDialog();
            modalForm.Dispose();
        }

        private void proOthersBtn_Click(object sender, EventArgs e)
        {
            Form2 modalForm = new Form2("제품");
            modalForm.Owner = this;
            modalForm.ShowDialog();
            modalForm.Dispose();
        }

        private void ordOthersBtn_Click(object sender, EventArgs e)
        {
            Form2 modalForm = new Form2("주문");
            modalForm.Owner = this;
            modalForm.ShowDialog();
            modalForm.Dispose();
        }

        private void areaDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexOfSelectedRow = e.RowIndex;
            DataGridViewRow row = areaDB.Rows[IndexOfSelectedRow];
            NameOfSelectedTab = ManagementTab.SelectedTab.Text;

            Form2 modalForm;
            if (NameOfSelectedTab == Tables[0] || NameOfSelectedTab == Tables[2])
            {
                modalForm = new Form2(
                    IndexOfSelectedRow,
                    NameOfSelectedTab,
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString()
                )
                {
                    Owner = this
                };
            }
            else
            {
                modalForm = new Form2(
                    IndexOfSelectedRow,
                    NameOfSelectedTab,
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString()
                )
                {
                    Owner = this
                };
            }
            // 새로운 폼에 선택된 row의 정보를 담아서 생성

            modalForm.ShowDialog();
            modalForm.Dispose();
        }

        private void cusClearBtn_Click(object sender, EventArgs e)
        {
            cusIdBox.Clear();
            cusNameBox.Clear();
            cusAgeBox.Clear();
            cusJobComboBox.Text = "";
            cusGradeComboBox.Text = "";
            cusAccumulationBox_min.Clear();
            cusAccumulationBox_max.Clear();
        }

        private void proClearBtn_Click(object sender, EventArgs e)
        {
            proProductNumberComboBox.Text = "";
            proProductNameBox.Clear();
            proStockBox_min.Clear();
            proStockBox_max.Clear();
            proPriceBox_min.Clear();
            proPriceBox_max.Clear();
            proManufacturerComboBox.Text = "";
        }

        private void ordClearBtn_Click(object sender, EventArgs e)
        {
            ordOrderNumberBox.Clear();
            ordCustomerBox.Clear();
            ordProductNumberComboBox.Text = "";
            ordDestinationBox.Clear();
            ordOrderDateComboBox.Text = "";
            ordQuantityBox_min.Clear();
            ordQuantityBox_max.Clear();
        }   
    }
}
