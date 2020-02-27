using UnityEngine;

namespace TinaXEditor.VFSKitInternal.I18N
{
    internal static class VFSConfigDashboardI18N
    {

        private static bool? _isChinese;
        private static bool IsChinese
        {
            get
            {
                if (_isChinese == null)
                {
                    _isChinese = (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified);
                }
                return _isChinese.Value;
            }
        }

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

        internal static string EnableVFS
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "����VFS";
                else
                    return "Enable VFS";
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

        internal static string GlobalVFS_Ignore_PathItem
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "����·����Ŀ";
                else
                    return "Ignore path item";
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

        internal static string Groups_Cannot_Be_Null
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "�뱣������һ��Group.";
                else
                    return "Please keep at least one group in config.";
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

        internal static string Window_GroupConfig_Title_SpecialFolder
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��ԴĿ¼���⹹������";
                else
                    return "Folder Special Build Rules";
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

        internal static string Window_Cannot_delete_internal_config_content
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "����VFS�ڲ����򣬲�����ɾ�����{0}";
                else
                    return "The item \"{0}\"cannot be remove because of VFS internal rules.";
            }
        }

        internal static string Window_Cannot_delete_internal_config_title
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "�����ɾ��";
                else
                    return "Cannot remove item.";
            }
        }

        internal static string Window_Group_HandleMode
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��Դ�� ����ģʽ��";
                else
                    return "Group handle type��";
            }
        }
        
        internal static string Window_Group_ObfuscateDirectoryStructure
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "����Ŀ¼�ṹ";
                else
                    return "Obfuscate Directory Structure";
            }
        }

        internal static string Window_Group_Extension
        {
            get
            {
                if (IsChinese) return "��չ�飺";
                return "Extension Group: ";
            }
        }

        internal static string Window_Group_Extensible_Tips
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��չ����Բ���������Ϸ��Դ�У���ӵ�ж����İ汾������ơ�\n��չ��ͨ����������Mod����DLC֮�����չ���ݡ�";
                else
                    return "Extension groups are allowed not to be included in game resources. They have independent version management mechanism. \nExtension groups are often used to make extended content such as mod or DLC.";
            }
        }

        internal static string Window_Group_IgnoreSubFolder
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "����������Ŀ¼��";
                else
                    return "Ignore The Following Subfolders";
            }
        }

        internal static string Window_Group_IgnoreSubFolder_MsgBox_NotSubfolder
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��ѡ����ļ��в����ǵ�ǰ�顰�������ļ��С������õ��κ�·������Ŀ¼:\n{0}";
                else
                    return "The folder you selected is not a subdirectory of any path configured in the current group \"Whitelist folder paths\":\n{0}";
            }
        }

        internal static string Menu_Build
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "������Դ";
                else
                    return "Build";
            }
        }

        internal static string Menu_Build_BaseAsset
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "������Դ����ĸ����";
                else
                    return "Complete assets package";
            }
        }

        internal static string Window_AB_Detail
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "AssetBundle ϸ������";
                else
                    return "AssetBundle detail setting";
            }
        }

        internal static string Window_AB_Extension_Name
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "AssetBundle �ļ���չ����";
                else
                    return "AssetBundle file extension name: ";
            }
        }

        internal static string Window_AB_Extension_Name_Tip_startwithdot
        {
            get
            {
                if (Application.systemLanguage == SystemLanguage.Chinese || Application.systemLanguage == SystemLanguage.ChineseSimplified)
                    return "��׺�����Ե��\".\"��ʼ��";
                else
                    return "Please start with dot \".\" for file extension.";
            }
        }
        
        internal static string Toolbar_FileServer_NotSupport
        {
            get
            {
                if (IsChinese) return "�ļ���������֧��";
                return "File Server Not Support";
            }
        }
        
        internal static string Toolbar_FileServer_Running
        {
            get
            {
                if (IsChinese) return "�ļ�������������";
                return "File Server Running";
            }
        }
        
        internal static string Toolbar_FileServer_Stopped
        {
            get
            {
                if (IsChinese) return "�ļ�������δ����";
                return "File Server Stopped";
            }
        }

        internal static string Toolbar_FileServer_OpenUI
        {
            get
            {
                if (IsChinese) return "�����ļ�������";
                return "Manage File Server";
            }
        }
        
        internal static string Toolbar_VersionMgr
        {
            get
            {
                if (IsChinese) return "�汾������";
                return "Versions Manager";
            }
        }

    }
}