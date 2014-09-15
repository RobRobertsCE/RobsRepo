using ClassBuilder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassBuilder.Logic
{
    public abstract class ClassWriter : ClassBuilder.IClassWriter
    {
        IMemberWriter writer;

        public ClassWriter(IMemberWriter writer)
        {
            this.writer = writer;
        }

        public string BuildClass(IDTObject model)
        {
            StringBuilder sb = new StringBuilder();

            OpenClassDeclaration(model, sb);

            BuildFields(model, sb);

            BuildProperties(model, sb);
            
            CloseClassDeclaration(sb);

            return sb.ToString();
        }

        void OpenClassDeclaration(IDTObject model, StringBuilder sb)
        {
            sb.AppendFormat("Public Class {0}\r\n", model.Name);
            sb.AppendLine();
        }

        void CloseClassDeclaration(StringBuilder sb)
        {
            sb.AppendLine("End Class");
        }

        void BuildFields(IDTObject model, StringBuilder sb)
        {
            BeginRegion("Fields", sb);

            foreach (IMember member in model.Members.OfType<MemberField>())
            {
                writer.BuildMember(member, sb);
                sb.AppendLine();
            }

            EndRegion(sb);
        }

        void BuildProperties(IDTObject model, StringBuilder sb)
        {
            BeginRegion("Properties", sb);

            foreach (IMember member in model.Members.OfType<MemberProperty>())
            {
                writer.BuildMember(member, sb);
                sb.AppendLine();
            }

            EndRegion(sb);
        }

        void BeginRegion(string regionName, StringBuilder sb)
        {
            sb.AppendFormat("#Region \" {0} \"\r\n", regionName);
            sb.AppendLine();
        }

        void EndRegion(StringBuilder sb)
        {
            sb.AppendLine("\r\n#EndRegion\r\n");
        }

    }
}
