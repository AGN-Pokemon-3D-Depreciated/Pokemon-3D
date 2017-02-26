Namespace BattleSystem

    Public Class MoveAnimationQueryObject : Inherits QueryObject

        Public Property Done As Boolean = False
        Public Property ObjectInit As Boolean = False

        Public Property ObjectEntity As Entity

        Public Sub New()
            MyBase.New(QueryTypes.MoveAnimation)
        End Sub

        Public Overrides ReadOnly Property IsReady As Boolean
            Get
                Return Done
            End Get
        End Property

        Public Overrides Sub Update(BV2Screen As BattleScreen)
            ' New Vector3(12, 0, 12.5F)
            ' New Vector3(15, 0, 12.5F)
            'If Not ObjectInit Then
            '    ObjectEntity = Entity.GetNewEntity("wallbill", New Vector3(12, 0, 12.75F) + BV2Screen.BattleMapOffset + New Vector3((1 - 0.25F) / 2, 0, 0), {TextureManager.GetTexture("Battle\Fire\EmberBall", New Rectangle(0, 0, 32, 32))}, {0, 0}, False, Vector3.Zero, New Vector3(0.25, 0.25, 1), BaseModel.getModelbyID(3), 0, "", True, Vector3.One, 13000013, "", "", Vector3.Zero)
            '    Screen.Level.Entities.Add(ObjectEntity)

            '    ObjectInit = True
            'End If

            'If ObjectEntity.Position.X < 15 Then
            '    ObjectEntity.Position = New Vector3(ObjectEntity.Position.X + 0.02F, ObjectEntity.Position.Y, ObjectEntity.Position.Z)
            '    ObjectEntity.CreatedWorld = False
            'Else
            '    Screen.Level.Entities.Remove(ObjectEntity)
            '    Done = True
            'End If
        End Sub

    End Class

End Namespace
