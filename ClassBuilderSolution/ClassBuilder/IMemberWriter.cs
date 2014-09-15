using ClassBuilder;
using System;
using System.Text;

namespace ClassBuilder
{
   public interface IMemberWriter
    {
        string BuildMember(IMember member, StringBuilder sb);
    }
}
