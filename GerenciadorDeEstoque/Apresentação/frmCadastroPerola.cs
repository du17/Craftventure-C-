
﻿using GerenciadorDeEstoque.DAO;
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
    public partial class frmCadastroPerola : Form
    {
        static String nome_material = "Pérola";
        PerolaVO perola;
        MaterialVO material;
        TipoMaterialVO tipoMaterial;
        String palavra;

        DataTable dt = new DataTable();

        bool novoClicado = false;

        public frmCadastroPerola()
        {
            InitializeComponent();
            Inicializar();
        }

        private void Inicializar()
        {
            dt = DAO.DAO.GetPerola();
            dgvPerolaKrypton.DataSource = dt;
            ConfigurarGradeFitas();
        }

        private void ConfigurarGradeFitas()
        {
            dgvPerolaKrypton.DefaultCellStyle.Font = new Font("Segoe UI Emoji", 20, FontStyle.Bold);
            dgvPerolaKrypton.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Emoji", 15, FontStyle.Bold);
            dgvPerolaKrypton.RowHeadersWidth = 20;
            dgvPerolaKrypton.RowTemplate.Height = 40;

            dgvPerolaKrypton.Columns["idTipoMaterial"].HeaderText = "ID";
            dgvPerolaKrypton.Columns["idTipoMaterial"].Visible = true;

            dgvPerolaKrypton.Columns["tamanho"].HeaderText = "Tamanho";
            dgvPerolaKrypton.Columns["tamanho"].Width = 130;
            dgvPerolaKrypton.Columns["tamanho"].DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);

            dgvPerolaKrypton.Columns["cor"].HeaderText = "Cor";
            dgvPerolaKrypton.Columns["cor"].Width = 120;
            dgvPerolaKrypton.Columns["cor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPerolaKrypton.Columns["cor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvPerolaKrypton.Columns["valor"].HeaderText = "Valor";
            dgvPerolaKrypton.Columns["valor"].Width = 100;
            dgvPerolaKrypton.Columns["valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPerolaKrypton.Columns["valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private object GetValorLinha(String campo)
        {
            return dgvPerolaKrypton.Rows[dgvPerolaKrypton.CurrentCell.RowIndex].Cells[campo].Value;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!novoClicado)
            {
                perola = new PerolaVO();


                try
                {
                    double tamanho = Convert.ToDouble(txtTamanho.Text);;
                    String cor = txtCor.Text;
                    double valor = Convert.ToDouble(txtValor.Text);

                    perola.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));
                    perola.Tamanho = tamanho;
                    perola.Cor = cor;
                    material.Valor = valor;

                    perola.Atualizar();

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
                perola = new PerolaVO();
                tipoMaterial = new TipoMaterialVO();
                material = new MaterialVO();

                long idTipoMaterial;

                try
                {
                    String cor = txtCor.Text;
                    Double tamanho = Convert.ToDouble(txtTamanho.Text);
                    double valor = Convert.ToDouble(txtValor.Text);

                    tipoMaterial.Nome = nome_material;
                    tipoMaterial.Inserir();

                    idTipoMaterial = tipoMaterial.getLastId();

                    material.IdTipoMaterial = idTipoMaterial;
                    material.Nome = nome_material;
                    material.Valor = valor;
                    material.Inserir();

                    perola.itemidTipoMaterial = idTipoMaterial;
                    perola.Cor = cor;
                    perola.Tamanho = tamanho;
                    perola.Inserir();

                    MessageBox.Show("Item Cadastrado!");

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

        private void LimpaTextos()
        {
            txtCor.Text = string.Empty;
            txtTamanho.Text = string.Empty;
            txtValor.Text = string.Empty;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            perola = new PerolaVO();

            try
            {
                DialogResult dialog = MessageBox.Show("Você tem certeza que dejesa EXCLUIR este item?\nEsta ação não pode ser desfeita", "Excluir papel: ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    perola.itemidTipoMaterial = Convert.ToInt64(GetValorLinha("idTipoMaterial"));

                    perola.Remover();
                    LimpaTextos();
                    Inicializar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (e.KeyChar != '\b')
                {
                    palavra += e.KeyChar;

                    dt = DAO.DAO.GetPerola();

                    dgvPerolaKrypton.DataSource = dt;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPerolaKrypton_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPerolaKrypton_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            perola = new PerolaVO();
            novoClicado = false;

            try
            {

                perola.Tamanho = Convert.ToDouble(GetValorLinha("tamanho"));
                perola.Cor = GetValorLinha("cor").ToString();
                material.Valor = Convert.ToDouble(GetValorLinha("valor"));

                txtCor.Text = perola.Cor.ToString();
                txtTamanho.Text = perola.Tamanho.ToString();
                txtValor.Text = material.Valor.ToString();

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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            novoClicado = true;
            dgvPerolaKrypton.CurrentCell.Selected = false;
            LimpaTextos();

            btnSalvar.StateNormal.Back.Image = Properties.Resources.Cadastrar_btn;
            btnSalvar.StateTracking.Back.Image = Properties.Resources.Cadastrar_Tracking;
            btnSalvar.StatePressed.Back.Image = Properties.Resources.Cadastrar_btn;


            btnLimpar.Enabled = false;
        }
    }
}
