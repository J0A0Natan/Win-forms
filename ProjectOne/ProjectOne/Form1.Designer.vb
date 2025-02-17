<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.TxtCell = New System.Windows.Forms.TextBox()
        Me.TxtTelefone = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonDell = New System.Windows.Forms.Button()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContatosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet1 = New ProjectOne.Database2DataSet1()
        Me.ContatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database2DataSet = New ProjectOne.Database2DataSet()
        Me.ContatosTableAdapter = New ProjectOne.Database2DataSetTableAdapters.contatosTableAdapter()
        Me.ContatosTableAdapter1 = New ProjectOne.Database2DataSet1TableAdapters.contatosTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonLimparForm = New System.Windows.Forms.Button()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ContatosBindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Database2DataSet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ContatosBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Database2DataSet,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(26, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(26, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(26, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(26, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefone"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(26, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-mail"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(128, 66)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(294, 20)
        Me.TxtNome.TabIndex = 5
        '
        'TxtEnd
        '
        Me.TxtEnd.Location = New System.Drawing.Point(128, 92)
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(294, 20)
        Me.TxtEnd.TabIndex = 6
        '
        'TxtCell
        '
        Me.TxtCell.Location = New System.Drawing.Point(128, 118)
        Me.TxtCell.Name = "TxtCell"
        Me.TxtCell.Size = New System.Drawing.Size(294, 20)
        Me.TxtCell.TabIndex = 7
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Location = New System.Drawing.Point(128, 144)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(294, 20)
        Me.TxtTelefone.TabIndex = 8
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(128, 170)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(294, 20)
        Me.TxtEmail.TabIndex = 9
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Location = New System.Drawing.Point(439, 66)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(101, 55)
        Me.ButtonNovo.TabIndex = 10
        Me.ButtonNovo.Text = "Cadastrar"
        Me.ButtonNovo.UseVisualStyleBackColor = true
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.Location = New System.Drawing.Point(571, 66)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(101, 55)
        Me.ButtonSalvar.TabIndex = 11
        Me.ButtonSalvar.Text = "Salvar"
        Me.ButtonSalvar.UseVisualStyleBackColor = true
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(439, 135)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(101, 55)
        Me.ButtonEdit.TabIndex = 12
        Me.ButtonEdit.Text = "Editar"
        Me.ButtonEdit.UseVisualStyleBackColor = true
        '
        'ButtonDell
        '
        Me.ButtonDell.Location = New System.Drawing.Point(571, 135)
        Me.ButtonDell.Name = "ButtonDell"
        Me.ButtonDell.Size = New System.Drawing.Size(101, 55)
        Me.ButtonDell.TabIndex = 13
        Me.ButtonDell.Text = "Deletar"
        Me.ButtonDell.UseVisualStyleBackColor = true
        '
        'ButtonSair
        '
        Me.ButtonSair.Location = New System.Drawing.Point(29, 18)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(80, 27)
        Me.ButtonSair.TabIndex = 14
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Agenda - Contatos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AutoGenerateColumns = false
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.EnderecoDataGridViewTextBoxColumn, Me.CelularDataGridViewTextBoxColumn, Me.TelefoneDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ContatosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(29, 220)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.Size = New System.Drawing.Size(643, 230)
        Me.DataGridView1.TabIndex = 18
        '
        'ContatosBindingSource1
        '
        Me.ContatosBindingSource1.DataMember = "contatos"
        Me.ContatosBindingSource1.DataSource = Me.Database2DataSet1
        '
        'Database2DataSet1
        '
        Me.Database2DataSet1.DataSetName = "Database2DataSet1"
        Me.Database2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContatosBindingSource
        '
        Me.ContatosBindingSource.DataMember = "contatos"
        Me.ContatosBindingSource.DataSource = Me.Database2DataSet
        '
        'Database2DataSet
        '
        Me.Database2DataSet.DataSetName = "Database2DataSet"
        Me.Database2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContatosTableAdapter
        '
        Me.ContatosTableAdapter.ClearBeforeFill = true
        '
        'ContatosTableAdapter1
        '
        Me.ContatosTableAdapter1.ClearBeforeFill = true
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = true
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = true
        '
        'EnderecoDataGridViewTextBoxColumn
        '
        Me.EnderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco"
        Me.EnderecoDataGridViewTextBoxColumn.HeaderText = "endereco"
        Me.EnderecoDataGridViewTextBoxColumn.Name = "EnderecoDataGridViewTextBoxColumn"
        Me.EnderecoDataGridViewTextBoxColumn.ReadOnly = true
        '
        'CelularDataGridViewTextBoxColumn
        '
        Me.CelularDataGridViewTextBoxColumn.DataPropertyName = "celular"
        Me.CelularDataGridViewTextBoxColumn.HeaderText = "celular"
        Me.CelularDataGridViewTextBoxColumn.Name = "CelularDataGridViewTextBoxColumn"
        Me.CelularDataGridViewTextBoxColumn.ReadOnly = true
        '
        'TelefoneDataGridViewTextBoxColumn
        '
        Me.TelefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone"
        Me.TelefoneDataGridViewTextBoxColumn.HeaderText = "telefone"
        Me.TelefoneDataGridViewTextBoxColumn.Name = "TelefoneDataGridViewTextBoxColumn"
        Me.TelefoneDataGridViewTextBoxColumn.ReadOnly = true
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = true
        Me.EmailDataGridViewTextBoxColumn.Width = 160
        '
        'ButtonLimparForm
        '
        Me.ButtonLimparForm.Location = New System.Drawing.Point(571, 18)
        Me.ButtonLimparForm.Name = "ButtonLimparForm"
        Me.ButtonLimparForm.Size = New System.Drawing.Size(101, 27)
        Me.ButtonLimparForm.TabIndex = 19
        Me.ButtonLimparForm.Text = "Limpar Formulario"
        Me.ButtonLimparForm.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(699, 462)
        Me.Controls.Add(Me.ButtonLimparForm)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.ButtonDell)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonSalvar)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTelefone)
        Me.Controls.Add(Me.TxtCell)
        Me.Controls.Add(Me.TxtEnd)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda de Contatos"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ContatosBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Database2DataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ContatosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Database2DataSet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtEnd As TextBox
    Friend WithEvents TxtCell As TextBox
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents ButtonNovo As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonDell As Button
    Friend WithEvents ButtonSair As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database2DataSet As Database2DataSet
    Friend WithEvents ContatosBindingSource As BindingSource
    Friend WithEvents ContatosTableAdapter As Database2DataSetTableAdapters.contatosTableAdapter
    Friend WithEvents Database2DataSet1 As Database2DataSet1
    Friend WithEvents ContatosBindingSource1 As BindingSource
    Friend WithEvents ContatosTableAdapter1 As Database2DataSet1TableAdapters.contatosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonLimparForm As Button
End Class
