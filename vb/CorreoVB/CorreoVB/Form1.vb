Public Class frmCorreoVB

    Dim arroba As Boolean

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click

        If (((txtCorreo.Text Like "[a-z]*@[!.]?*.[a-z][a-z][a-z].[a-z][a-z]") Or (txtCorreo.Text Like "[a-z]*@[!.]?*.[a-z][a-z][a-z]")) And Not (txtCorreo.Text Like "*@*@*") And Not (txtCorreo.Text Like "*@*.*.*.*") And Not (txtCorreo.Text Like "*--*") And Not (txtCorreo.Text Like "*..*")) Then

            If ((txtCorreo.Text Like "*[/]*") Or (txtCorreo.Text Like "*[!]*") Or (txtCorreo.Text Like "*[*]*") Or (txtCorreo.Text Like "*[,]*") Or (txtCorreo.Text Like "*[[]*") Or (txtCorreo.Text Like "*[]]*") Or (txtCorreo.Text Like "*[\]*") Or (txtCorreo.Text Like "*[+]*") Or (txtCorreo.Text Like "*[=]*") Or (txtCorreo.Text Like "*[{]*") Or (txtCorreo.Text Like "*[}]*") Or (txtCorreo.Text Like "*[|]*") Or (txtCorreo.Text Like "*[&]*") Or (txtCorreo.Text Like "*[(]*") Or (txtCorreo.Text Like "*[)]*") Or (txtCorreo.Text Like "*[;]*") Or (txtCorreo.Text Like "*[:]*") Or (txtCorreo.Text Like "*[']*") Or (txtCorreo.Text Like "*[^]*") Or (txtCorreo.Text Like "*[%]*") Or (txtCorreo.Text Like "*[$]*") Or (txtCorreo.Text Like "*[#]*") Or (txtCorreo.Text Like "*[`]*") Or (txtCorreo.Text Like "*[~]*") Or (txtCorreo.Text Like "*[<]*") Or (txtCorreo.Text Like "*[>]*") Or (txtCorreo.Text Like "*[ ]*") Or (txtCorreo.Text Like "*[?]*")) Then

                MsgBox("Correo Invalido")

            Else

                MsgBox("Correo Valido")

            End If



        Else

            MsgBox("Correo Invalido")

        End If


    End Sub



End Class
