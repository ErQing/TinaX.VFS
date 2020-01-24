using UnityEngine;

namespace TinaXEditor.VFSKit
{
    internal static class VFSConfigDashboardI18N
    {
        internal static string WindowTitle
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "VFS ���";
                else
                    return "VFS Dashboard";
            }
        }

        internal static string GlobalVFS_Ignore_ExtName
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "���Ժ�׺��";
                else
                    return "Ignore extname";
            }
        }


        internal static string MsgBox_Common_Error
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��̫�Ծ�";
                else
                    return "Oops!";
            }
        }

        internal static string MsgBox_Common_Confirm
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "�ð�";
                else
                    return "Okey";
            }
        }

        internal static string MsgBox_Msg_CreateGroupNameIsNull
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��Դ��������ЧŶ.";
                else
                    return "The asset group name you want to create is not valid.";
            }
        }

        internal static string MsgBox_Msg_CreateGroupNameHasExists
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "Ҫ��������Դ�������\"{0}\"�Ѿ����ڿ�.";
                else
                    return "The name \"{0}\" of the assets group you want to create already exists.";
            }
        }

        internal static string Groups_Item_Null_Tips
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��ǰ������û���κ���Դ����Ϣ�����ڴ����Ϸ��������½���Դ�顣";
                else
                    return "There is no assets group information in the current configuration. Please create a new in the toolbar above the window.";
            }
        }


        internal static string Window_GroupConfig_Null_Tips
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "ѡ��һ����Դ��.";
                else
                    return "Select a group.";
            }
        }

        internal static string Window_GroupConfig_Title_GroupName
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��Դ�飺";
                else
                    return "Asset Group: ";
            }
        }


        internal static string Window_GroupConfig_Title_FolderPaths
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "�������ļ���·����";
                else
                    return "Whitelist folder paths: ";
            }
        }

        internal static string Window_GroupConfig_Title_AssetPaths
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��������Դ·����";
                else
                    return "Whitelist asset paths: ";
            }
        }

        internal static string Window_GroupConfig_SelectFolder
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "ѡ���ļ��У�";
                else
                    return "Select a folder: ";
            }
        }
        internal static string Window_GroupConfig_SelectAsset
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "ѡ����Դ��";
                else
                    return "Select a asset: ";
            }
        }

        internal static string Window_GroupConfig_SelectAsset_Error_Select_Meta
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "������ѡ��\".meta\"��׺���ļ�����VFS����";
                else
                    return "Can not select a \".meta\" file to add VFS Asset list.";
            }
        }

    }
}