Imports System.Web.Mvc

Namespace Controllers
    Public Class DATA_CENTERController
        Inherits Controller

        ' GET: DATA_CENTER

        Function GET_FULL_MODEL() As JsonResult
            Dim model As New MODEL_APP
            model.DETAIL_DATA = GET_DETAIL_ALL()
            model.USERNAME = "นนท์ bear"
            model.CLS_TABLE_USER_LIST.Add(AddValue(model.CLS_TABLE_USER))
            model.CLS_TABLE_USER_LIST.Add(AddValue(model.CLS_TABLE_USER))
            Return Json(model, JsonRequestBehavior.AllowGet)
        End Function

        Function GET_DETAIL_ALL()
            Dim DAO As New DAO_TEST_NEW.TB_TABLE_USER
            DAO.Get_Alldata()
            Return DAO.datas
        End Function

        Function CHECK_USER_PASS(ByVal USERNAME As String, ByVal PASS As String)
            Dim dao As New DAO_TEST_NEW.TB_TABLE_USER
            dao.GET_PROFILE_BY_LOGIN(USERNAME, PASS)
            Dim result As String = "SUCCESS"
            If dao.field.IDA = 0 Then
                result = "FAIL"
            End If
            Return result
        End Function

        Function REGISTER_USER(ByVal model As MODEL_APP)
            Dim RESULT As String = "SUCCESS"
            Dim dao As New DAO_TEST_NEW.TB_TABLE_USER
            dao.GET_USERNAE_BYUSER(model.CLS_TABLE_USER.USERNAME)

            If dao.field.IDA = 0 Then
                dao = New DAO_TEST_NEW.TB_TABLE_USER
                dao.field = model.CLS_TABLE_USER
                'dao.field.USERNAME = SET_DETAIL.USERNAME
                'dao.field.PASSWORD = SET_DETAIL.PASSWORD
                dao.insert()
                model.RESULT_FUNC = GET_DETAIL_ALL()
            Else
                RESULT = "มีการใช้งานแล้ว"
            End If

            model.RESULT_STR = RESULT

            Return model
        End Function

        Function SELECT_BY_USER(ByVal USER As String)
            Dim dao As New DAO_TEST_NEW.TB_TABLE_USER
            dao.GET_USERNAE_BYUSER(USER)
            Return dao.field
        End Function

        Function EDIT_USER_PASS(ByVal MODEL As MODEL_APP)
            Dim dao As New DAO_TEST_NEW.TB_TABLE_USER
            dao.GET_USERNAE_BYUSER(MODEL.USERNAME)
            If dao.field.IDA = 0 Then
                dao.GET_USERNAE_BYUSER(MODEL.CLS_TABLE_USER.USERNAME)
                dao.field.USERNAME = MODEL.USERNAME
                dao.field.PASSWORD = MODEL.PASSWORD
                dao.update()
                MODEL.RESULT_STR = "SUSCESS"
                MODEL.RESULT_FUNC = dao.datas
            Else
                MODEL.RESULT_STR = "มีผู้ใช้งานแล้ว"
            End If

            Return MODEL
        End Function


        Function DEL_BY_USER(ByVal USER As String)
            Dim result As String = "SUCCESS"
            Try
                Dim dao As New DAO_TEST_NEW.TB_TABLE_USER
                dao.GET_USERNAE_BYUSER(USER)

                If dao.field.IDA = 0 Then
                    result = "ไม่พบข้อมูล"
                Else
                    dao.delete()
                End If
            Catch ex As Exception
                result = "เกิดข้อผิดพลาดกรุณาแจ้งผู้ดูแล"
            End Try
            Return result
        End Function

        Function GATEWAY_DATA(ByVal MODEL As MODEL_APP)

            Select Case MODEL.FUNC_CODE
                Case "FUNC-CHK_UP-001"
                    MODEL.RESULT_FUNC = CHECK_USER_PASS(MODEL.USERNAME, MODEL.PASSWORD)
                Case "FUNC-RGT-001"
                    MODEL = REGISTER_USER(MODEL)
                Case "FUNC-SEL-001"
                    MODEL.RESULT_FUNC = SELECT_BY_USER(MODEL.USERNAME)
                Case "FUNC-DEL-001"
                    MODEL.RESULT_FUNC = DEL_BY_USER(MODEL.USERNAME)
                Case "FUNC-EDIT-001"
                    MODEL = EDIT_USER_PASS(MODEL)
                Case Else
                    MODEL.RESULT_STR = "ไม่พบฟังก์ชั่น"
            End Select

            Return Json(MODEL, JsonRequestBehavior.AllowGet)
        End Function


    End Class
End Namespace