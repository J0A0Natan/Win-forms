MustInherit Public Class IContato
    'Propriedades
    Public Property Id As Integer
    Public Property Nome As String
    Public Property Endereco As String
    Public Property Celular As String
    Public Property Telefone As String
    Public Property Email As String

    'Metodos
    MustOverride Public Function NovoContato() As Boolean

    MustOverride Public Function AtualizarContato() As Boolean

    MustOverride Public Function ListarContato() As DataTable

    MustOverride Public Function ListarContatoEditar(idCont As Integer) As Array

    MustOverride Public Function DeletarContato(id As Integer) As Boolean
End Class