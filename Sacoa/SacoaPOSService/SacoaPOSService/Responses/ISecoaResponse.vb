﻿Namespace Responses

    Public Interface ISecoaResponse

        ''' <summary>
        ''' OK or ERROR
        ''' </summary>
        ReadOnly Property ResponseState As String

        ''' <summary>
        ''' The name of the response data structure.
        ''' </summary>
        ReadOnly Property ResponseName As String

    End Interface

End Namespace