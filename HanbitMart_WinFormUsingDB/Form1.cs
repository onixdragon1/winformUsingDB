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

        private void Form1_Load(object sender, EventArgs e)
        {
            // 각 테이블에 담긴 초기 데이터를 각 테이블에 맞는 DataView에 뿌리고
            // 뿌려진 데이터 중 특정 컬럼들을 콤보박스에 세팅
            string connectionString = "server=localhost;port=3306;database=HanbitMart;uid=root;pwd=angleeha77@@A";
            conn = new MySqlConnection(connectionString);
            dataSet = new DataSet();

            adapter = new MySqlDataAdapter("SELECT * FROM 고객", conn);
            adapter.Fill(dataSet, "고객");

            adapter = new MySqlDataAdapter("SELECT * FROM 제품", conn);
            adapter.Fill(dataSet, "제품");

            adapter = new MySqlDataAdapter("SELECT * FROM 주문", conn);
            adapter.Fill(dataSet, "주문");
            
            customerDataView.DataSource = dataSet.Tables["고객"]; 
            productDataView.DataSource = dataSet.Tables["제품"];
            orderDataView.DataSource = dataSet.Tables["주문"];
            
            Setting("고객"); Setting("제품"); Setting("주문");
        }

        private void ManagementTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameOfSelectedTab = ManagementTab.SelectedTab.Text;
            adapter = new MySqlDataAdapter("SELECT * FROM "+NameOfSelectedTab, conn);
            dataSet.Clear();
            adapter.Fill(dataSet, NameOfSelectedTab);
            if (NameOfSelectedTab == "고객")
                customerDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
            else if (NameOfSelectedTab == "제품")
                productDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
            else if (NameOfSelectedTab == "주문")
                orderDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
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

            string[] options = new string[customerDataView.Columns.Count];
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
                        else queryString += "and " + options[i];
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
                dataSet.Clear();
                if (adapter.Fill(dataSet, "고객") > 0)
                    customerDataView.DataSource = dataSet.Tables["고객"];
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

            string[] options = new string[productDataView.Columns.Count];
            options[0] = (proProductNumberComboBox.Text != "") ? "제품번호=@제품번호" : null;
            options[1] = (proProductNameBox.Text != "") ? "제품명=@제품명" : null;
            options[2] = (proStockBox_min.Text != "") ? "재고량=@재고량" : null;
            string options_Price;
            if (proPriceBox_min.Text != "" && proPriceBox_max.Text != "")
            {
                options_Price = "단가>=@Price_min and 단가<=@Price_max";
            }
            else if (proPriceBox_min.Text != "" || proPriceBox_max.Text != "")
            {
                if (proPriceBox_min.Text != "")
                    options_Price = "단가>=@Price_min";
                else options_Price = "단가<=@Price_max";
            }
            else
            {
                options_Price = null;
            }
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
                        else queryString += "and " + options[i];
                    }
                }
            }
            else queryString = "SELECT * FROM 제품";

            adapter.SelectCommand = new MySqlCommand(queryString, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@제품번호", proProductNumberComboBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@제품명", proProductNameBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@재고량", proStockBox_min.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@제조업체", proManufacturerComboBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Price_min", proPriceBox_min.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Price_max", proPriceBox_max.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (adapter.Fill(dataSet, "제품") > 0)
                    customerDataView.DataSource = dataSet.Tables["제품"];
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

            string[] options = new string[orderDataView.Columns.Count];
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
                        else queryString += "and " + options[i];
                    }
                }
            }
            else queryString = "SELECT * FROM 주문";

            adapter.SelectCommand = new MySqlCommand(queryString, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@주문번호", ordOrderNumberBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@주문고객", ordCustomerBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@제품번호", ordProductNumberComboBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@배송지", ordDestinationBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@주문일자", ordOrderDateComboBox.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Quantity_min", ordQuantityBox_min.Text);
            adapter.SelectCommand.Parameters.AddWithValue("@Quantity_max", ordQuantityBox_max.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (adapter.Fill(dataSet, "주문") > 0)
                    customerDataView.DataSource = dataSet.Tables["주문"];
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

        private void customerDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexOfSelectedRow = e.RowIndex;
            DataGridViewRow rows = customerDataView.Rows[IndexOfSelectedRow];

            Form2 modalForm = new Form2(
                IndexOfSelectedRow,
                ManagementTab.SelectedTab.Text,
                rows.Cells[0].Value.ToString(),
                rows.Cells[1].Value.ToString(),
                rows.Cells[2].Value.ToString(),
                rows.Cells[3].Value.ToString(),
                rows.Cells[4].Value.ToString(),
                rows.Cells[5].Value.ToString()
                )
            {
                Owner = this
            };
            modalForm.ShowDialog();
            modalForm.Dispose();
        }

        private void productDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexOfSelectedRow = e.RowIndex;
            DataGridViewRow rows = productDataView.Rows[IndexOfSelectedRow];

            Form2 modalForm = new Form2(
                IndexOfSelectedRow,
                ManagementTab.SelectedTab.Text,
                rows.Cells[0].Value.ToString(),
                rows.Cells[1].Value.ToString(),
                rows.Cells[2].Value.ToString(),
                rows.Cells[3].Value.ToString(),
                rows.Cells[4].Value.ToString()
                )
            {
                Owner = this
            };
            modalForm.ShowDialog();
            modalForm.Dispose();
        }
        
        private void orderDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndexOfSelectedRow = e.RowIndex;
            DataGridViewRow rows = orderDataView.Rows[IndexOfSelectedRow];

            Form2 modalForm = new Form2(
                IndexOfSelectedRow,
                ManagementTab.SelectedTab.Text,
                rows.Cells[0].Value.ToString(),
                rows.Cells[1].Value.ToString(),
                rows.Cells[2].Value.ToString(),
                rows.Cells[3].Value.ToString(),
                rows.Cells[4].Value.ToString(),
                rows.Cells[5].Value.ToString()
                )
            {
                Owner = this
            };
            modalForm.ShowDialog();
            modalForm.Dispose();
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
                adapter.InsertCommand = new MySqlCommand(queryString, conn);
                adapter.InsertCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@제품명", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@재고량", MySqlDbType.Int32);
                adapter.InsertCommand.Parameters.Add("@단가", MySqlDbType.Int32);
                adapter.InsertCommand.Parameters.Add("@제조업체", MySqlDbType.VarChar);

                #region Parameters를 이용한 데이터 삽입 처리
                adapter.InsertCommand.Parameters["@제품번호"].Value = rowDatas[0];
                adapter.InsertCommand.Parameters["@제품명"].Value = rowDatas[1];
                adapter.InsertCommand.Parameters["@재고량"].Value = Convert.ToInt32(rowDatas[2]);
                adapter.InsertCommand.Parameters["@단가"].Value = Convert.ToInt32(rowDatas[3]);
                adapter.InsertCommand.Parameters["@제조업체"].Value = rowDatas[4];
                #endregion
            }
            else if (NameOfSelectedTab == "주문")
            {
                // INSERT 쿼리 사용을 위해 선언하고 데이터 타입 지정
                queryString = "INSERT INTO 주문 VALUES(@주문번호, @주문고객, @제품번호, @수량, @배송지, @주문일자)";
                adapter.InsertCommand = new MySqlCommand(queryString, conn);
                adapter.InsertCommand.Parameters.Add("@주문번호", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@주문고객", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@제품번호", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@수량", MySqlDbType.Int32);
                adapter.InsertCommand.Parameters.Add("@배송지", MySqlDbType.VarChar);
                adapter.InsertCommand.Parameters.Add("@주문일자", MySqlDbType.Date);

                #region Parameters를 이용한 데이터 삽입 처리
                adapter.InsertCommand.Parameters["@주문번호"].Value = rowDatas[0];
                adapter.InsertCommand.Parameters["@주문고객"].Value = rowDatas[1];
                adapter.InsertCommand.Parameters["@제품번호"].Value = rowDatas[2];
                adapter.InsertCommand.Parameters["@수량"].Value = Convert.ToInt32(rowDatas[3]);
                adapter.InsertCommand.Parameters["@배송지"].Value = rowDatas[4];
                adapter.InsertCommand.Parameters["@주문일자"].Value = rowDatas[5];
                #endregion
            }
            try
            {
                conn.Open();
                adapter.InsertCommand.ExecuteNonQuery();

                dataSet.Clear();  // 선택한 테이블의 이전 데이터 지우기
                adapter.Fill(dataSet, NameOfSelectedTab);

                if (NameOfSelectedTab == "고객")
                    customerDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
                else if (NameOfSelectedTab == "제품")
                    productDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
                else if (NameOfSelectedTab == "주문")
                    orderDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
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
                adapter.UpdateCommand = new MySqlCommand(queryString, conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDatas[0]);
                adapter.UpdateCommand.Parameters.AddWithValue("@제품명", rowDatas[1]);
                adapter.UpdateCommand.Parameters.AddWithValue("@재고량", rowDatas[2]);
                adapter.UpdateCommand.Parameters.AddWithValue("@단가", rowDatas[3]);
                adapter.UpdateCommand.Parameters.AddWithValue("@제조업체", rowDatas[4]);
            }
            else if (NameOfSelectedTab == "주문")
            {
                queryString = "UPDATE 주문 SET 주문고객=@주문고객, 제품번호=@제품번호, 수량=@수량, 배송지=@배송지, 주문일자=@주문일자 WHERE 주문번호=@주문번호";
                adapter.UpdateCommand = new MySqlCommand(queryString, conn);
                adapter.UpdateCommand.Parameters.AddWithValue("@주문번호", rowDatas[0]);
                adapter.UpdateCommand.Parameters.AddWithValue("@주문고객", rowDatas[1]);
                adapter.UpdateCommand.Parameters.AddWithValue("@제품번호", rowDatas[2]);
                adapter.UpdateCommand.Parameters.AddWithValue("@수량", rowDatas[3]);
                adapter.UpdateCommand.Parameters.AddWithValue("@배송지", rowDatas[4]);
                adapter.UpdateCommand.Parameters.AddWithValue("@주문일자", rowDatas[5]);
            }
            try
            {
                conn.Open();
                adapter.UpdateCommand.ExecuteNonQuery();

                dataSet.Clear();  // 선택한 테이블의 이전 데이터 지우기
                adapter.Fill(dataSet, NameOfSelectedTab);
                if (NameOfSelectedTab == "고객")
                    customerDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
                else if (NameOfSelectedTab == "제품")
                    productDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
                else if(NameOfSelectedTab == "주문") 
                    orderDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
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
                adapter.DeleteCommand = new MySqlCommand(queryString, conn);
                adapter.DeleteCommand.Parameters.AddWithValue("@제품번호", PrimaryKey);
            }
            else if (NameOfSelectedTab == "주문")
            {
                queryString = "DELETE FROM 주문 WHERE 주문번호=@주문번호";
                adapter.DeleteCommand = new MySqlCommand(queryString, conn);
                adapter.DeleteCommand.Parameters.AddWithValue("@주문번호", PrimaryKey);
            }
            try
            {
                conn.Open();
                adapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();  // 선택한 테이블의 이전 데이터 지우기
                adapter.Fill(dataSet, NameOfSelectedTab);
                if (NameOfSelectedTab == "고객")
                    customerDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
                else if (NameOfSelectedTab == "제품")
                    productDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
                else if (NameOfSelectedTab == "주문")
                    orderDataView.DataSource = dataSet.Tables[NameOfSelectedTab];
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
