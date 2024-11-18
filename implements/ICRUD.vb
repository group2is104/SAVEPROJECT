Public Interface ICRUD(Of T)
    Sub InsertData(data As T)
    Function SelectData(id As Integer) As T
    Sub UpdateData(data As T)
    Sub DeleteData(data As T)
    Function UpdateList() As List(Of T)
End Interface

