Imports SacoaService

Public Class Form1

#Region " Constants "
    Private Const PosId As String = "1234"
    Private Const EmpId As String = "5678"
    Private Const TestServer As String = "200.80.220.106"
    Private Const TestPort As Integer = 14434
    Private Const TestCommandListResponse As String = "OK,SUPPORTED COMMANDS,35,POSServer Internal Commands:, <pos>;CARD DATA;<card>;<emp>, <pos>;CARD DEBIT;<range>;<cred>;<bon>;<court>;(stat);(minutes);(payment);(deposit);<ppt>;<debitcode>;<emp>, <pos>;CARD DECODE;<card>;<emp>, <pos>;CARD RECHARGE;<range>;<cred>;<bon>;<court>;<stat>;{minutes};<payment>;(deposit);<ppt>;<emp>, <pos>;CARD REFUND;<range>;<cred>;<bon>;<court>;(stat);(minutes);<payment>;(deposit);<ppt>;<emp>, <pos>;CARD ROAM;<card>;<emp>, <pos>;CARD SALE;<range>;<cred>;<bon>;<court>;<stat>;{minutes};<payment>;<deposit>;<ppt>;<emp>, <pos>;CARD SET;<range>;<cred>;<bon>;<court>;<stat>;{minutes};<payment>;(deposit);<ppt>;<emp>, <pos>;CARD SET CHILD;<range>;<newstate(0|1)>;<emp>, <pos>;CARD TRANSFER;<sourcecard>;<destcard>;<emp>, <pos>;CARDS CONSOLIDATE;<sourcecardqty>;<destcard>;<srccard1>[;<srccard2>[;<srccard3>[;<srccard4>]]];<emp>, <pos>;DELAYED RECHARGE;<range>;<cred>;<bon>;<court>;<stat>;{minutes};<payment>;(deposit);<ppt>;{HCType};<yyyymmdd>;<hhnn>;<emp>, <pos>;SELL PROMO;<range>;<cred>;<bon>;<court>;<stat>;{minutes};<payment>;<deposit>;<ppt>;<paymodename>;<paymodeid>;<productqty>;<salemodeid>;<invoice>;<emp>, <pos>;SUPPORTED COMMANDS;<includeplugininfo=yes>;<emp>, <pos>;TICKETS ADD;<range>;<tickets>;<emp>, <pos>;TICKETS RMV;<range>;<tickets>;<emp>, <pos>;TICKETS SET TYPE;<range>;<newtype(R|V)>;<emp>, <pos>;VERSION;<emp>,Plugin [POS Plugin Cashier v1.13] Commands:, <PosID>;sp_LogLegacyCashierTransaction;<TransID>;<CashierCode>;<CashierName>;<CardNumber>;<CardQty>;<SModeID>;<Amount>;<CardCharge>;<PModeName>;<Credits>;<Bonus>;<Courtesy>;<Minutes>;<Tickets>;<ComputerName>;<XMLData>, <PosID>;CredCardEngineReady;<EmpID>, <PosID>;CredCardAuthorize;<TransID>;<CCTrack1>;<CCTrack2>;<CCTrack3>;<CCRawMagData>;<Subtotal>;<Tax>;<EmpID>,Plugin [POS Plugin HyperPassport v1.01] Commands:, <pos>;HP_Add_To_Card;<cardnumber>;<hp_id>;<hp_qty>;<emp>, <pos>;HP_List_For_Card;<cardnumber>;<availablenow[0|1]>;<emp>, <pos>;HP_Kill_For_Card;<cardnumber>;<emp>, <pos>;HP_List_Types;<emp>,Plugin [POS Plugin Party2 v1.12] Commands:, <PosID>;PostPartyData;<CPUName>;<PartyType>;<CardQty>;<TotalCharged>;<PayMode>;<EmpID>, <PosID>;RegisterPartyDownPayment;<CPUName>;<PartyID>;<dbPaymentAmount>;<lPayModeID>;<sCredCardName>;<sCredCardNumber>;<lPaymentPlayCard>;<sRemoteTransactionID>;<EmpID>,Plugin [POS Plugin Sample v1.12] Commands:, <pos>;Is_Card_In_Range;<cardnumber>;<rangename>;<emp>,Plugin [POS Plugin StopTC v1.12] Commands:, <pos>;Stop_TCard_Clock;<cardnumber>;<emp>"
    Private Const TestCardDataResponse As String = "OK,CARD DATA,123,40,120,0,O,99,1,100,10,140908,140320,104443,075852,0,0,0,70,2908,0,0,,2868,0,V  "
    Private Const TestCardHistoryResponse As String = "OK, CARD HISTORY, 111, 111, 20130228183314;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4375;4352, 20130408174406;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4376;4352, 20130412160856;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4377;4352, 20130612155254;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4382;4352, 20130612173845;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4383;4352, 20130612173845;504F53205265636861726765;1;4E65772050617373;50617373706F72742033;1;2;4384;4352, 20130617123126;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4387;4352, 20130618180323;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4395;4352, 20130618180334;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4396;4352, 20130723165540;41646D696E697374726174697665205265636861726765;0;;43726564697473;124.77;12;113;4352, 20130723165704;41646D696E697374726174697665205265636861726765;0;;43726564697473;150;12;114;4352, 20131129153747;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4458;4352, 20131129161343;504F53205265636861726765;1;486F7420446F67;;0;2;4460;4352, 20131129161343;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4462;4352, 20140131144259;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4501;4352, 20140131144335;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4502;4352, 20140213121738;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4504;4352, 20140217110702;504F53205265636861726765;12;5265736572766174696F6E205061796D656E74;;0;2;4507;4352, 20140226080416;5061796D656E74;0;;43726564697473;-1.2;3;585;4352, 20140226080937;5061796D656E74;0;;43726564697473;-1.2;3;586;4352, 20140226101905;5061796D656E74;0;;43726564697473;-0.1;3;587;4352, 20140226102539;5061796D656E74;0;;43726564697473;-0.1;3;588;4352, 20140226141549;5061796D656E74;0;;43726564697473;-1.2;3;589;4352, 20140227051721;5061796D656E74;0;;43726564697473;-0.1;3;590;4352, 20140227115839;5061796D656E74;0;;43726564697473;-0.1;3;591;4352, 20140227140512;5061796D656E74;0;;43726564697473;-0.1;3;592;4352, 20140227144819;5061796D656E74;0;;43726564697473;-0.1;3;593;4352, 20140227145111;5061796D656E74;0;;43726564697473;-0.1;3;594;4352, 20140228094801;5061796D656E74;0;;43726564697473;-0.1;3;595;4352, 20140303063051;5061796D656E74;0;;43726564697473;-0.1;3;596;4352, 20140303083652;5061796D656E74;0;;43726564697473;-0.1;3;597;4352, 20140303084010;5061796D656E74;0;;43726564697473;-0.1;3;598;4352, 20140303084202;5061796D656E74;0;;43726564697473;-0.1;3;599;4352, 20140303090546;5061796D656E74;0;;43726564697473;-0.1;3;600;4352, 20140303124629;5061796D656E74;0;;43726564697473;-0.1;3;601;4352, 20140303125253;5061796D656E74;0;;43726564697473;-0.1;3;602;4352, 20140304124613;5061796D656E74;0;;43726564697473;-0.01;3;603;4352, 20140304130539;5061796D656E74;0;;43726564697473;-1;3;604;4352, 20140304135333;5061796D656E74;0;;43726564697473;-0.01;3;606;4352, 20140304140233;5061796D656E74;0;;43726564697473;-0.1;3;608;4352, 20140304141201;5061796D656E74;0;;43726564697473;-0.01;3;609;4352, 20140304141301;5061796D656E74;0;;43726564697473;-0.3;3;610;4352, 20140304141408;5061796D656E74;0;;43726564697473;-0.1;3;611;4352, 20140305134638;5061796D656E74;0;;43726564697473;-0.1;3;612;4352, 20140307085225;5061796D656E74;0;;43726564697473;-0.01;3;613;4352, 20140307104202;5061796D656E74;0;;43726564697473;-0.01;3;614;4352, 20140307104640;5061796D656E74;0;;43726564697473;-0.1;3;615;4352, 20140307105713;5061796D656E74;0;;43726564697473;-0.01;3;616;4352, 20140307115324;5061796D656E74;0;;43726564697473;-0.01;3;617;4352, 20140307121300;5061796D656E74;0;;43726564697473;-0.01;3;618;4352, 20140307123154;5061796D656E74;0;;43726564697473;-0.01;3;619;4352, 20140307135417;5061796D656E74;0;;43726564697473;-0.01;3;620;4352, 20140307135641;5061796D656E74;0;;43726564697473;-0.01;3;621;4352, 20140307140902;5061796D656E74;0;;43726564697473;-0.01;3;622;4352, 20140307141009;5061796D656E74;0;;43726564697473;-0.01;3;623;4352, 20140307141231;5061796D656E74;0;;43726564697473;-0.01;3;624;4352, 20140307141403;5061796D656E74;0;;43726564697473;-0.01;3;625;4352, 20140307141429;5061796D656E74;0;;43726564697473;-0.01;3;626;4352, 20140310111643;5061796D656E74;0;;43726564697473;-0.02;3;627;4352, 20140310112000;5061796D656E74;0;;43726564697473;-0.01;3;628;4352, 20140310112215;5061796D656E74;0;;43726564697473;-0.01;3;629;4352, 20140310112456;5061796D656E74;0;;43726564697473;-0.01;3;630;4352, 20140310112716;5061796D656E74;0;;43726564697473;-0.01;3;631;4352, 20140310114437;5061796D656E74;0;;43726564697473;-0.01;3;632;4352, 20140310115920;5061796D656E74;0;;43726564697473;-0.01;3;635;4352, 20140310115941;5061796D656E74;0;;43726564697473;-0.01;3;636;4352, 20140311103139;5061796D656E74;0;;43726564697473;-0.01;3;639;4352, 20140311103207;5061796D656E74;0;;43726564697473;-0.01;3;640;4352, 20140311122620;504F53205265636861726765;0;;43726564697473;100;2;642;4352, 20140311123049;5061796D656E74;0;;43726564697473;-1;3;643;4352, 20140311123204;5061796D656E74;0;;43726564697473;-1;3;645;4352, 20140311123333;5061796D656E74;0;;43726564697473;-1;3;646;4352, 20140311123426;5061796D656E74;0;;43726564697473;-1;3;647;4352, 20140312131714;5061796D656E74;0;;43726564697473;-2.7;3;648;4352, 20140312132102;5061796D656E74;0;;43726564697473;-4.4;3;649;4352, 20140320073635;5061796D656E74;0;;43726564697473;-1;3;650;4352, 20140320073946;5061796D656E74;0;;43726564697473;-1;3;651;4352, 20140320074104;5061796D656E74;0;;43726564697473;-1;3;652;4352, 20140320075852;5061796D656E74;0;;43726564697473;-1;3;653;4352, 20140516145538;41646D696E697374726174697665205265636861726765;0;;43726564697473;-80.74;12;266;4352, 20140522102530;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4561;4352, 20140522103539;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4562;4352, 20140522104027;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4563;4352, 20140522110350;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4565;4352, 20140522110817;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4566;4352, 20140522113519;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4567;4352, 20140522113700;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4568;4352, 20140522114122;504F53205265636861726765;1;446F75626C652043686172676520243130;43726564697473;10;2;4569;4352, 20140522114122;504F53205265636861726765;1;446F75626C652043686172676520243130;426F6E7573;10;2;4569;4352, 20140523123403;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4570;4352, 20140527143047;504F53205265636861726765;1;3130207265636861726765;43726564697473;10;2;4571;4352, 20140528115813;504F53205265636861726765;15;43726564697420572F546178;43726564697473;150;2;4573;4352, 20140528115813;504F53205265636861726765;1;31204C6173657220546167;;0;2;4574;4352, 20140529124226;504F53205265636861726765;15;43726564697420572F546178;43726564697473;150;2;4575;4352, 20140610112024;504F53205265636861726765;1;3230207265636861726765;43726564697473;20;2;4576;4352, 20140610112132;504F5320526"
    Private Const TestCardDecodeResponse As String = "OK,CARD DECODE,123"
#End Region

#Region " Fields "
    Dim service As SacoaService.SacoaService = Nothing
#End Region

#Region " Form Load "
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            service = New SacoaService.SacoaService(TestPort, TestServer)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " Common [exception handler, messsage display] "
    Private Sub ExceptionHandler(ex As Exception)
        Display(ex.Message)
        Console.WriteLine(ex.ToString())
    End Sub

    Private Sub Display(message As String)
        Dim updateUIInvoker As New MethodInvoker(Sub()
                                                     txtDisplay.AppendText(message & Environment.NewLine)
                                                 End Sub)
        Me.Invoke(updateUIInvoker)
    End Sub

    Private Sub ClearDisplay()
        txtDisplay.Clear()
    End Sub
#End Region

#Region " SacoaSupportedCommandsRequest "

#Region " GetSacoaSupportedCommandsRequest "
    Private Function GetSacoaSupportedCommandsRequest() As SacoaService.Request.SacoaSupportedCommandsRequest
        Dim sacoaRequest As New SacoaService.Request.SacoaSupportedCommandsRequest(PosId, EmpId)
        If chkIncludeHandlerInfo.Checked Then
            sacoaRequest.IncludeHandlerInfo = "Yes"
        Else
            sacoaRequest.IncludeHandlerInfo = "No"
        End If
        Return sacoaRequest
    End Function
#End Region

#Region " Button Click Handlers "
    Private Sub btnSendAsync_Click(sender As Object, e As EventArgs) Handles btnSendCommandListRequestAsync.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaSupportedCommandsRequest()

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSendCommandListRequest.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaSupportedCommandsRequest()

            Dim SacoaResponse As SacoaService.Response.SacoaSupportedCommandsResponse = service.SendRequest(sacoaRequest)

            DisplaySacoaSupportedCommandsResponse(SacoaResponse)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnTestResponse_Click(sender As Object, e As EventArgs) Handles btnTestResponse.Click
        Try
            Dim response As New SacoaService.Response.SacoaSupportedCommandsResponse(TestCommandListResponse)
            DisplaySacoaSupportedCommandsResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " SacoaResponseDelegate "
    Public Sub SacoaResponseDelegate(e As SacoaService.Response.ISacoaResponse)
        Try
            Dim response As SacoaService.Response.SacoaSupportedCommandsResponse = DirectCast(e, SacoaService.Response.SacoaSupportedCommandsResponse)
            DisplaySacoaSupportedCommandsResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " Display Response "
    Private Sub DisplaySacoaSupportedCommandsResponse(response As SacoaService.Response.SacoaSupportedCommandsResponse)
        Try
            Display(String.Format("Response Name: {0}", response.ResponseName))
            Display(String.Format("Response Status: {0}", response.ResponseState))

            Dim idx As Integer = 0
            For Each op As SacoaService.Logic.SacoaOpDescription In response.OpDescriptions
                Display("Op #" + idx.ToString())
                Display(String.Format("  Op Name: {0}", op.RequestName))
                Console.WriteLine(String.Format("{0,-3}  {1,-50} Op Name: {2}", idx.ToString(), op.OpContainerName, op.RequestName))
                Display(String.Format("  Op Container: {0}", op.OpContainerName))
                Display(String.Format("  Op Params ({0})", op.RequestParamList.Count))
                Display("---------------------")
                For Each param As String In op.RequestParamList
                    Display(String.Format("    {0}", param))
                Next
                Display(Environment.NewLine)
                idx += 1
            Next
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#End Region

#Region " SacoaCardDataRequest "

#Region " GetSacoaCardDataRequest "
    Private Function GetSacoaCardDataRequest() As SacoaService.Request.SacoaCardDataRequest
        Dim sacoaRequest As New SacoaService.Request.SacoaCardDataRequest(PosId, EmpId)
        sacoaRequest.CardNumber = txtCardDataNumber.Text
        Return sacoaRequest
    End Function
#End Region

#Region " Button Click Handlers "
    Private Sub btnSendCardDataRequest_Click(sender As Object, e As EventArgs) Handles btnSendCardDataRequest.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaCardDataRequest()

            Dim SacoaResponse As SacoaService.Response.SacoaCardDataResponse = service.SendRequest(sacoaRequest)

            DisplaySacoaCardDataResponse(SacoaResponse)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnSendCardDataRequestAsync_Click(sender As Object, e As EventArgs) Handles btnSendCardDataRequestAsync.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaCardDataRequest()

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardDataResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnTestParseCardDataResponse_Click(sender As Object, e As EventArgs) Handles btnTestParseCardDataResponse.Click
        Try
            Dim response As New SacoaService.Response.SacoaCardDataResponse(TestCardDataResponse)
            DisplaySacoaCardDataResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " Sacoa Response Delegate "
    Public Sub SacoaCardDataResponseDelegate(e As SacoaService.Response.ISacoaResponse)
        Try
            Dim response As SacoaService.Response.SacoaCardDataResponse = DirectCast(e, SacoaService.Response.SacoaCardDataResponse)
            DisplaySacoaCardDataResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " DisplaySacoaCardDataResponse "
    Private Sub DisplaySacoaCardDataResponse(response As SacoaService.Response.SacoaCardDataResponse)
        Try
            Display(String.Format("Response Name: {0}", response.ResponseName))
            Display(String.Format("Response Status: {0}", response.ResponseState))
            Display(String.Format("Response CardRange: {0}", response.CardRange))
            Display(String.Format("Response Credits: {0}", response.Credits))
            Display(String.Format("Response Bonus: {0}", response.Bonus))
            Display(String.Format("Response Courtesy: {0}", response.Courtesy))
            Display(String.Format("Response Status: {0}", response.Status))
            Display(String.Format("Response Station: {0}", response.Station))
            Display(String.Format("Response LastGameId: {0}", response.LastGameId))
            Display(String.Format("Response CreditsLastBought: {0}", response.CreditsLastBought))
            Display(String.Format("Response CreditsLastPlayed: {0}", response.CreditsLastPlayed))
            Display(String.Format("Response DateLastBought: {0}", response.DateLastBought))
            Display(String.Format("Response DateLastPlayed: {0}", response.DateLastPlayed))
            Display(String.Format("Response TimeLastBought: {0}", response.TimeLastBought))
            Display(String.Format("Response TimeLastPlayed: {0}", response.TimeLastPlayed))
            Display(String.Format("Response ConsecutiveDays: {0}", response.ConsecutiveDays))
            Display(String.Format("Response TotalDays: {0}", response.TotalDays))
            Display(String.Format("Response TotalBuys: {0}", response.TotalBuys))
            Display(String.Format("Response TotalSwipes: {0}", response.TotalSwipes))
            Display(String.Format("Response TotalCreditsBought: {0}", response.TotalCreditsBought))
            Display(String.Format("Response OldPassports: {0}", response.OldPassports))
            Display(String.Format("Response Tickets: {0}", response.Tickets))
            Display(String.Format("Response CreditsEngineCredits: {0}", response.CreditsEngineCredits))
            Display(String.Format("Response TotalCreditsPlayed: {0}", response.TotalCreditsPlayed))
            Display(String.Format("Response ChildStatus: {0}", response.ChildStatus))
            Display(String.Format("Response TicketType: {0}", response.TicketType))
            Display("_______________________________________________________")
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#End Region

#Region " SacoaCardHistoryRequest "

#Region " GetSacoaCardHistoryRequest "
    Private Function GetSacoaCardHistoryRequest() As SacoaService.Request.SacoaCardHistoryRequest
        Dim sacoaRequest As New SacoaService.Request.SacoaCardHistoryRequest(PosId, EmpId)
        sacoaRequest.CardNumber = txtCardHistoryNumber.Text
        sacoaRequest.DesiredRecords = Convert.ToInt32(txtCardHistoryCount.Text)
        Return sacoaRequest
    End Function
#End Region

#Region " Button Click Handlers "
    Private Sub btnSendCardHistoryRequest_Click(sender As Object, e As EventArgs) Handles btnSendCardHistoryRequest.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaCardHistoryRequest()

            Dim SacoaResponse As SacoaService.Response.SacoaCardHistoryResponse = service.SendRequest(sacoaRequest)

            DisplaySacoaCardHistoryResponse(SacoaResponse)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnSendCardHistoryRequestAsync_Click(sender As Object, e As EventArgs) Handles btnSendCardHistoryRequestAsync.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaCardHistoryRequest()

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardHistoryResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnTestParseCardHistoryResponse_Click(sender As Object, e As EventArgs) Handles btnTestParseCardHistoryResponse.Click
        Try
            Dim response As New SacoaService.Response.SacoaCardHistoryResponse(TestCardHistoryResponse)
            DisplaySacoaCardHistoryResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " Sacoa Response Delegate "
    Public Sub SacoaCardHistoryResponseDelegate(e As SacoaService.Response.ISacoaResponse)
        Try
            Dim response As SacoaService.Response.SacoaCardHistoryResponse = DirectCast(e, SacoaService.Response.SacoaCardHistoryResponse)
            DisplaySacoaCardHistoryResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " DisplaySacoaCardHistoryResponse "
    Private Sub DisplaySacoaCardHistoryResponse(response As SacoaService.Response.SacoaCardHistoryResponse)
        Try
            Display(String.Format("Response Name: {0}", response.ResponseName))
            Display(String.Format("Response Status: {0}", response.ResponseState))
            Display(String.Format("TotalRecordCount: {0}", response.TotalRecordCount))
            Display(String.Format("RetreivedRecordCount: {0}", response.RetreivedRecordCount))
            For Each cardHistory As SacoaService.Logic.SacoaCardHistory In response.CardHistory
                Display(String.Format(" OpDate: {0}", cardHistory.OpDate))
                Display(String.Format(" OpName: {0}", cardHistory.OpName))
                Display(String.Format(" OpQty: {0}", cardHistory.OpQty))
                Display(String.Format(" OpConcept: {0}", cardHistory.OpConcept))
                Display(String.Format(" OpCounter: {0}", cardHistory.OpCounter))
                Display(String.Format(" OpAmount: {0}", cardHistory.OpAmount))
                Display(String.Format(" OpType: {0}", cardHistory.OpType))
                Display(String.Format(" OpTransId: {0}", cardHistory.OpTransId))
                Display(String.Format(" OpStoreId: {0}", cardHistory.OpStoreId))
                Display(Environment.NewLine)
                'Console.WriteLine(String.Format("{0,-30} {1}", cardHistory.OpName, cardHistory.OpType))
            Next
            Display(Environment.NewLine)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#End Region

#Region " SacoaCardDecodeRequest "

#Region " GetSacoaCardDecodeRequest "
    Private Function GetSacoaCardDecodeRequest() As SacoaService.Request.SacoaCardDecodeRequest
        Dim sacoaRequest As New SacoaService.Request.SacoaCardDecodeRequest(PosId, EmpId)
        sacoaRequest.CardNumber = txtCardHistoryNumber.Text
        Return sacoaRequest
    End Function
#End Region

#Region " Button Click Handlers "
    Private Sub btnSendCardDecodeRequest_Click(sender As Object, e As EventArgs) Handles btnSendCardDecodeRequest.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaCardDecodeRequest()

            Dim SacoaResponse As SacoaService.Response.SacoaCardDecodeResponse = service.SendRequest(sacoaRequest)

            DisplaySacoaCardDecodeResponse(SacoaResponse)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnSendCardDecodeRequestAsync_Click(sender As Object, e As EventArgs) Handles btnSendCardDecodeRequestAsync.Click
        Try
            ClearDisplay()

            Dim sacoaRequest = GetSacoaCardDecodeRequest()

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardDecodeResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

    Private Sub btnTestParseCardDecodeResponse_Click(sender As Object, e As EventArgs) Handles btnTestParseCardDecodeResponse.Click
        Try
            Dim response As New SacoaService.Response.SacoaCardDecodeResponse(TestCardDecodeResponse)
            DisplaySacoaCardDecodeResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " Sacoa Response Delegate "
    Public Sub SacoaCardDecodeResponseDelegate(e As SacoaService.Response.ISacoaResponse)
        Try
            Dim response As SacoaService.Response.SacoaCardDecodeResponse = DirectCast(e, SacoaService.Response.SacoaCardDecodeResponse)
            DisplaySacoaCardDecodeResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " DisplaySacoaCardDecodeResponse "
    Private Sub DisplaySacoaCardDecodeResponse(response As SacoaService.Response.SacoaCardDecodeResponse)
        Try
            Display(String.Format("Response Name: {0}", response.ResponseName))
            Display(String.Format("Response Status: {0}", response.ResponseState))
            Display(String.Format("CardNumber: {0}", response.CardNumber))

            Display(Environment.NewLine)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#End Region

#Region " SacoaTicketsAddRequest "
    Private Sub btnAddTickets_Click(sender As Object, e As EventArgs) Handles btnAddTickets.Click
        Try
            Dim sacoaRequest As New SacoaService.Request.SacoaTicketsAddRequest(PosId, EmpId)
            sacoaRequest.CardRange = txtCard.Text
            sacoaRequest.TicketAmount = Convert.ToInt32(txtAddTicketCount.Text)

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardDataResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub

#End Region

#Region " SacoaTicketsAddRequest "
    Private Sub btnTicketsRmv_Click(sender As Object, e As EventArgs) Handles btnTicketsRmv.Click
        Try
            Dim sacoaRequest As New SacoaService.Request.SacoaTicketsRemoveRequest(PosId, EmpId)
            sacoaRequest.CardRange = txtCard.Text
            sacoaRequest.TicketAmount = Convert.ToInt32(txtRemoveTicketCount.Text)

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardDataResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " SacoaCardSetRequest "
    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Try
            Dim sacoaRequest As New SacoaService.Request.SacoaCardSetRequest(PosId, EmpId)
            sacoaRequest.CardRange = txtCard.Text
            sacoaRequest.Credits = txtCredits.Text
            sacoaRequest.Bonus = txtBonus.Text
            sacoaRequest.Courtesy = txtCourtesy.Text
            sacoaRequest.Status = txtStatus.Text
            sacoaRequest.Minutes = txtMinutes.Text
            sacoaRequest.MoneyPaid = txtMoneyPaid.Text
            sacoaRequest.CardCharge = txtCardCharge.Text
            sacoaRequest.OldPassports = txtOldPassports.Text

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardDataResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " SacoaCardSaleRequest "
    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        Try
            Dim sacoaRequest As New SacoaService.Request.SacoaCardSaleRequest(PosId, EmpId)
            sacoaRequest.CardRange = txtCard.Text
            sacoaRequest.Credits = txtCredits.Text
            sacoaRequest.Bonus = txtBonus.Text
            sacoaRequest.Courtesy = txtCourtesy.Text
            sacoaRequest.Status = txtStatus.Text
            sacoaRequest.Minutes = txtMinutes.Text
            sacoaRequest.MoneyPaid = txtMoneyPaid.Text
            sacoaRequest.CardCharge = txtCardCharge.Text
            sacoaRequest.OldPassports = txtOldPassports.Text

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardDataResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " SacoaCardRechargeRequest "
    Private Sub btnRecharge_Click(sender As Object, e As EventArgs) Handles btnRecharge.Click
        Try
            Dim sacoaRequest As New SacoaService.Request.SacoaCardRechargeRequest(PosId, EmpId)
            sacoaRequest.CardRange = txtCard.Text
            sacoaRequest.Credits = txtCredits.Text
            sacoaRequest.Bonus = txtBonus.Text
            sacoaRequest.Courtesy = txtCourtesy.Text
            sacoaRequest.Status = txtStatus.Text
            sacoaRequest.Minutes = txtMinutes.Text
            sacoaRequest.MoneyPaid = txtMoneyPaid.Text
            sacoaRequest.CardCharge = txtCardCharge.Text
            sacoaRequest.OldPassports = txtOldPassports.Text

            service.SendRequestAsync(sacoaRequest, AddressOf SacoaCardDataResponseDelegate)

        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

#Region " Ping "
    Private Sub btnPing_Click(sender As Object, e As EventArgs) Handles btnPing.Click
        Try
            Dim sacoaRequest As New SacoaService.Request.SacoaPingRequest(PosId, EmpId)
            sacoaRequest.TimeOutSeconds = 10
            service.SendRequestAsync(sacoaRequest, AddressOf SacoaPingResponseDelegate)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
    Public Sub SacoaPingResponseDelegate(e As SacoaService.Response.ISacoaResponse)
        Try
            Dim response As SacoaService.Response.SacoaPingResponse = DirectCast(e, SacoaService.Response.SacoaPingResponse)
            DisplaySacoaPingResponse(response)
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
    Private Sub DisplaySacoaPingResponse(response As SacoaService.Response.SacoaPingResponse)
        Try
            Display(String.Format("Response Name: {0}", response.ResponseName))
            Display(String.Format("Response Status: {0}", response.ResponseState))
            Display(String.Format("Response Result: {0}", response.Result))
            Display(String.Format("Response TimeOutSeconds: {0}", response.TimeoutSeconds))
            Display("_______________________________________________________")
        Catch ex As Exception
            ExceptionHandler(ex)
        End Try
    End Sub
#End Region

End Class
