
namespace UITarefa
{
    partial class FormTarefa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tarefaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdicionarTarefa = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonExcluirTarefa = new System.Windows.Forms.Button();
            this.comentarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAdicionarComentario = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxBuscarComentario = new System.Windows.Forms.TextBox();
            this.buttonBuscarComentario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tarefaDataGridView
            // 
            this.tarefaDataGridView.AllowUserToAddRows = false;
            this.tarefaDataGridView.AllowUserToDeleteRows = false;
            this.tarefaDataGridView.AllowUserToOrderColumns = true;
            this.tarefaDataGridView.AutoGenerateColumns = false;
            this.tarefaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tarefaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.tarefaDataGridView.DataSource = this.tarefaBindingSource;
            this.tarefaDataGridView.Location = new System.Drawing.Point(12, 41);
            this.tarefaDataGridView.Name = "tarefaDataGridView";
            this.tarefaDataGridView.ReadOnly = true;
            this.tarefaDataGridView.Size = new System.Drawing.Size(784, 198);
            this.tarefaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataSource = typeof(Model.Tarefa);
            // 
            // buttonAdicionarTarefa
            // 
            this.buttonAdicionarTarefa.Location = new System.Drawing.Point(12, 245);
            this.buttonAdicionarTarefa.Name = "buttonAdicionarTarefa";
            this.buttonAdicionarTarefa.Size = new System.Drawing.Size(131, 23);
            this.buttonAdicionarTarefa.TabIndex = 1;
            this.buttonAdicionarTarefa.Text = "Adicionar tarefa";
            this.buttonAdicionarTarefa.UseVisualStyleBackColor = true;
            this.buttonAdicionarTarefa.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(685, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(111, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar tarefa";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(12, 12);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(667, 20);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // buttonExcluirTarefa
            // 
            this.buttonExcluirTarefa.Location = new System.Drawing.Point(149, 245);
            this.buttonExcluirTarefa.Name = "buttonExcluirTarefa";
            this.buttonExcluirTarefa.Size = new System.Drawing.Size(124, 23);
            this.buttonExcluirTarefa.TabIndex = 4;
            this.buttonExcluirTarefa.Text = "Excluir tarefa";
            this.buttonExcluirTarefa.UseVisualStyleBackColor = true;
            this.buttonExcluirTarefa.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // comentarioBindingSource
            // 
            this.comentarioBindingSource.DataSource = typeof(Model.Comentario);
            // 
            // buttonAdicionarComentario
            // 
            this.buttonAdicionarComentario.Location = new System.Drawing.Point(12, 488);
            this.buttonAdicionarComentario.Name = "buttonAdicionarComentario";
            this.buttonAdicionarComentario.Size = new System.Drawing.Size(131, 23);
            this.buttonAdicionarComentario.TabIndex = 6;
            this.buttonAdicionarComentario.Text = "Adicionar comentário";
            this.buttonAdicionarComentario.UseVisualStyleBackColor = true;
            this.buttonAdicionarComentario.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // comentarioDataGridView
            // 
            this.comentarioDataGridView.AllowUserToAddRows = false;
            this.comentarioDataGridView.AllowUserToDeleteRows = false;
            this.comentarioDataGridView.AutoGenerateColumns = false;
            this.comentarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comentarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8});
            this.comentarioDataGridView.DataSource = this.comentarioBindingSource;
            this.comentarioDataGridView.Location = new System.Drawing.Point(12, 309);
            this.comentarioDataGridView.Name = "comentarioDataGridView";
            this.comentarioDataGridView.ReadOnly = true;
            this.comentarioDataGridView.Size = new System.Drawing.Size(784, 173);
            this.comentarioDataGridView.TabIndex = 5;
            this.comentarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.comentarioDataGridView_CellContentClick);
            // 
            // textBoxBuscarComentario
            // 
            this.textBoxBuscarComentario.Location = new System.Drawing.Point(13, 283);
            this.textBoxBuscarComentario.Name = "textBoxBuscarComentario";
            this.textBoxBuscarComentario.Size = new System.Drawing.Size(666, 20);
            this.textBoxBuscarComentario.TabIndex = 7;
            // 
            // buttonBuscarComentario
            // 
            this.buttonBuscarComentario.Location = new System.Drawing.Point(685, 280);
            this.buttonBuscarComentario.Name = "buttonBuscarComentario";
            this.buttonBuscarComentario.Size = new System.Drawing.Size(111, 23);
            this.buttonBuscarComentario.TabIndex = 8;
            this.buttonBuscarComentario.Text = "Buscar comentário";
            this.buttonBuscarComentario.UseVisualStyleBackColor = true;
            this.buttonBuscarComentario.Click += new System.EventHandler(this.buttonBuscarComentario_Click);
            // 
            // FormTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 523);
            this.Controls.Add(this.buttonBuscarComentario);
            this.Controls.Add(this.textBoxBuscarComentario);
            this.Controls.Add(this.buttonAdicionarComentario);
            this.Controls.Add(this.comentarioDataGridView);
            this.Controls.Add(this.buttonExcluirTarefa);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonAdicionarTarefa);
            this.Controls.Add(this.tarefaDataGridView);
            this.Name = "FormTarefa";
            this.Text = "Controle de tarefas";
            this.Load += new System.EventHandler(this.FormTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tarefaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView tarefaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button buttonAdicionarTarefa;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonExcluirTarefa;
        private System.Windows.Forms.BindingSource comentarioBindingSource;
        private System.Windows.Forms.Button buttonAdicionarComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView comentarioDataGridView;
        private System.Windows.Forms.TextBox textBoxBuscarComentario;
        private System.Windows.Forms.Button buttonBuscarComentario;
    }
}

