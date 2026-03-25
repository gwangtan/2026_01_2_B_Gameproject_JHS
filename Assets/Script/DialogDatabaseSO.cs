using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "DialogDatabaseSO", menuName = "Dialog System/DialogDatabaseSO")]
public class DialogDatabaseSO : ScriptableObject
{
    public List<DialogSO> dialogs = new List<DialogSO>();

    private Dictionary<int, DialogSO> dialogsByld;

    public void initialize()
    {
        dialogsByld = new Dictionary<int, DialogSO>();

        foreach (var dialog in dialogs)
        {
            if (dialog != null)
            {
                dialogsByld[dialog.id] = dialog;
            }
        }
    }


    public DialogSO GetDialongByld (int id)
    {
        if (dialogsByld == null)
            initialize();
        if(dialogsByld.TryGetValue(id, out DialogSO dialog))
        {
            return dialog;
        }

        return null;
    }
}
