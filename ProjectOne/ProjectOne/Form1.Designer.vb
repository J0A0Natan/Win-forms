﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCell = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtEnd = New System.Windows.Forms.TextBox()
        Me.TxtCell = New System.Windows.Forms.TextBox()
        Me.TxtTelefone = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.cmdCadastrar = New System.Windows.Forms.Button()
        Me.cmdSalvar = New System.Windows.Forms.Button()
        Me.cmdEditar = New System.Windows.Forms.Button()
        Me.cmdDeletar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContatosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContatosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContatosTableAdapter = New ProjectOne.Database2DataSetTableAdapters.contatosTableAdapter()
        Me.ContatosTableAdapter1 = New ProjectOne.Database2DataSet1TableAdapters.contatosTableAdapter()
        Me.cmdLimparForm = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatorioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ContatosBindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ContatosBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = true
        Me.lblUserName.Location = New System.Drawing.Point(25, 95)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(35, 13)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "Nome"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = true
        Me.lblEndereco.Location = New System.Drawing.Point(25, 121)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 1
        Me.lblEndereco.Text = "Endereço"
        '
        'lblCell
        '
        Me.lblCell.AutoSize = true
        Me.lblCell.Location = New System.Drawing.Point(25, 147)
        Me.lblCell.Name = "lblCell"
        Me.lblCell.Size = New System.Drawing.Size(39, 13)
        Me.lblCell.TabIndex = 2
        Me.lblCell.Text = "Celular"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = true
        Me.lblTel.Location = New System.Drawing.Point(25, 173)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(49, 13)
        Me.lblTel.TabIndex = 3
        Me.lblTel.Text = "Telefone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = true
        Me.lblEmail.Location = New System.Drawing.Point(25, 199)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 4
        Me.lblEmail.Text = "E-mail"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(127, 92)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(294, 20)
        Me.TxtNome.TabIndex = 5
        '
        'TxtEnd
        '
        Me.TxtEnd.Location = New System.Drawing.Point(127, 118)
        Me.TxtEnd.Name = "TxtEnd"
        Me.TxtEnd.Size = New System.Drawing.Size(294, 20)
        Me.TxtEnd.TabIndex = 6
        '
        'TxtCell
        '
        Me.TxtCell.Location = New System.Drawing.Point(127, 144)
        Me.TxtCell.Name = "TxtCell"
        Me.TxtCell.Size = New System.Drawing.Size(294, 20)
        Me.TxtCell.TabIndex = 7
        '
        'TxtTelefone
        '
        Me.TxtTelefone.Location = New System.Drawing.Point(127, 170)
        Me.TxtTelefone.Name = "TxtTelefone"
        Me.TxtTelefone.Size = New System.Drawing.Size(294, 20)
        Me.TxtTelefone.TabIndex = 8
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(127, 196)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(294, 20)
        Me.TxtEmail.TabIndex = 9
        '
        'cmdCadastrar
        '
        Me.cmdCadastrar.Location = New System.Drawing.Point(438, 92)
        Me.cmdCadastrar.Name = "cmdCadastrar"
        Me.cmdCadastrar.Size = New System.Drawing.Size(101, 55)
        Me.cmdCadastrar.TabIndex = 10
        Me.cmdCadastrar.Text = "Cadastrar"
        Me.cmdCadastrar.UseVisualStyleBackColor = true
        '
        'cmdSalvar
        '
        Me.cmdSalvar.Location = New System.Drawing.Point(570, 92)
        Me.cmdSalvar.Name = "cmdSalvar"
        Me.cmdSalvar.Size = New System.Drawing.Size(101, 55)
        Me.cmdSalvar.TabIndex = 11
        Me.cmdSalvar.Text = "Salvar"
        Me.cmdSalvar.UseVisualStyleBackColor = true
        '
        'cmdEditar
        '
        Me.cmdEditar.Location = New System.Drawing.Point(438, 161)
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(101, 55)
        Me.cmdEditar.TabIndex = 12
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.UseVisualStyleBackColor = true
        '
        'cmdDeletar
        '
        Me.cmdDeletar.Location = New System.Drawing.Point(570, 161)
        Me.cmdDeletar.Name = "cmdDeletar"
        Me.cmdDeletar.Size = New System.Drawing.Size(101, 55)
        Me.cmdDeletar.TabIndex = 13
        Me.cmdDeletar.Text = "Deletar"
        Me.cmdDeletar.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(222, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Agenda - Contatos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = false
        Me.DataGridView1.AllowUserToDeleteRows = false
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 246)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = true
        Me.DataGridView1.Size = New System.Drawing.Size(643, 275)
        Me.DataGridView1.TabIndex = 18
        '
        'ContatosTableAdapter
        '
        Me.ContatosTableAdapter.ClearBeforeFill = true
        '
        'ContatosTableAdapter1
        '
        Me.ContatosTableAdapter1.ClearBeforeFill = true
        '
        'cmdLimparForm
        '
        Me.cmdLimparForm.Location = New System.Drawing.Point(570, 44)
        Me.cmdLimparForm.Name = "cmdLimparForm"
        Me.cmdLimparForm.Size = New System.Drawing.Size(101, 27)
        Me.cmdLimparForm.TabIndex = 19
        Me.cmdLimparForm.Text = "Limpar Formulario"
        Me.cmdLimparForm.UseVisualStyleBackColor = true
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(699, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem, Me.RelatorioToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem1.Text = "Opções"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'RelatorioToolStripMenuItem
        '
        Me.RelatorioToolStripMenuItem.Name = "RelatorioToolStripMenuItem"
        Me.RelatorioToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RelatorioToolStripMenuItem.Text = "Relatorio"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(699, 533)
        Me.Controls.Add(Me.cmdLimparForm)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdDeletar)
        Me.Controls.Add(Me.cmdEditar)
        Me.Controls.Add(Me.cmdSalvar)
        Me.Controls.Add(Me.cmdCadastrar)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtTelefone)
        Me.Controls.Add(Me.TxtCell)
        Me.Controls.Add(Me.TxtEnd)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblCell)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda de Contatos"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ContatosBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ContatosBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblCell As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtEnd As TextBox
    Friend WithEvents TxtCell As TextBox
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents cmdCadastrar As Button
    Friend WithEvents cmdSalvar As Button
    Friend WithEvents cmdEditar As Button
    Friend WithEvents cmdDeletar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContatosBindingSource As BindingSource
    Friend WithEvents ContatosTableAdapter As Database2DataSetTableAdapters.contatosTableAdapter
    Friend WithEvents ContatosBindingSource1 As BindingSource
    Friend WithEvents ContatosTableAdapter1 As Database2DataSet1TableAdapters.contatosTableAdapter
    Friend WithEvents cmdLimparForm As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatorioToolStripMenuItem As ToolStripMenuItem
End Class
