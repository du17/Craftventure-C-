﻿using GerenciadorDeEstoque.DAO;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeEstoque.Apresentação
{
    public partial class frmCadastroCanudo : Form
    {
        static String nome_material = "Canudo";
        CanudoVO canudo;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;
        String palavra;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastroCanudo()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetCanudo();
            dgvCanudoKrypton.DataSource = dt;
            ConfigurarGradeLivros();
        }

        private void ConfigurarGradeLivros()
        {
            dgvCanudoKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvCanudoKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvCanudoKrypton.RowHeadersWidth = 20;
            dgvCanudoKrypton.RowTemplate.Height = 40;

            dgvCanudoKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvCanudoKrypton.Columns["idTipoMaterial"].Visible = true;

            dgvCanudoKrypton.Columns["quantidade"].HeaderText = "Quantidade";
            dgvCanudoKrypton.Columns["quantidade"].Width = 200;
            dgvCanudoKrypton.Columns["quantidade"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCanudoKrypton.Columns["quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvCanudoKrypton.Columns["cor"].HeaderText = "Cor";
            dgvCanudoKrypton.Columns["cor"].Width = 200;
            dgvCanudoKrypton.Columns["cor"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvCanudoKrypton.Columns["valor"].HeaderText = "Valor";
            dgvCanudoKrypton.Columns["valor"].Width = 100;
            dgvCanudoKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCanudoKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private object GetValorLinha(String campo)
        {
            return dgvCanudoKrypton.Rows[dgvCanudoKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que gostaria sair? (todas as informações não salvas serão apagadas)", "Saindo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            canudo = new CanudoVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir canudo: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    canudo.itemidproduto = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    canudo.Remover();
                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpaTextos()
        {
            txtValor.Text = string.Empty;
            txtCor.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            //pbCanudo.Image = null;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (!novoClicado)
            {
                canudo = new CanudoVO();


                try
                {
                    string cor = txtCor.Text;
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    double valor = Convert.ToDouble(txtValor.Text);

                    canudo.itemidproduto = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    canudo.Quantidade = quantidade;
                    canudo.Cor = cor;
                    material.Valor = valor;

                    canudo.Atualizar();

                    MessageBox.Show("Item Atualizado!");

                    Inicializar();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                canudo = new CanudoVO();
                material = new MaterialVO();
                tipoMaterial = new TipoMaterialVO();

                try
                {
                    string cor = txtCor.Text;
                    int quantidade = Convert.ToInt32(txtQuantidade.Text);
                    double valor = Convert.ToDouble(txtValor.Text);
                    long idTipoMaterial;

                    canudo.Cor = cor;
                    canudo.Quantidade = quantidade;

                    material.Valor = valor;
                    material.Nome = nome_material;

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    canudo.itemidproduto = idTipoMaterial;
                    material.IdMaterial = idTipoMaterial;

                    material.Inserir();

                    canudo.Inserir();

                    MessageBox.Show("Item Cadastrado!");

                    LimpaTextos();
                    Inicializar();

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { novoClicado = false; }
            }

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
           
        }

        //botão de adicionar um novo elemento
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            novoClicado = true;
            dgvCanudoKrypton.CurrentCell.Selected = false;
            LimpaTextos();

            btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
            btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
            btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


            btnLimpar.Enabled = false;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (e.KeyChar != '\b')
                {
                    palavra += e.KeyChar;

                    dt = DAO.DAO.GetCanudo();

                    dgvCanudoKrypton.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCanudoKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            canudo = new CanudoVO();

            novoClicado = false;

            try
            {

                canudo.Quantidade = Convert.ToInt32(GetValorLinha("quantidade"));
                canudo.Cor = GetValorLinha("cor").ToString();

                txtQuantidade.Text = canudo.Quantidade.ToString();
                txtCor.Text = canudo.Cor;
                txtValor.Text = GetValorLinha("valor").ToString();

                btnSalvar.StateNormal.Back.Image = Properties.Resources.SALVAR;
                btnSalvar.StateTracking.Back.Image = Properties.Resources.Salvar_Tracking;
                btnSalvar.StatePressed.Back.Image = Properties.Resources.SALVAR;

                btnLimpar.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString());
            }

        }
    }
}
