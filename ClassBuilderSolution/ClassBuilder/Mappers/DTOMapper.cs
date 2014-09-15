using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassBuilder.Data;
using ClassBuilder.Models;

namespace ClassBuilder.Mappers
{
    internal static class DTOMapper
    {
        internal static ClassModel ToModel(IDTObject dtObject)
        {
            ClassModel model =  new ClassModel();

            foreach (IMember member in dtObject.Members)
            {
                model.Members.Add(MemberMapper.ToModel(member));    
            }
            
            return model;
        }

        internal static IDTObject ToDTObject(ClassModel model)
        {
            IDTObject dtObject = new DTObject(model.ClassKey , model.Name, model.ModelNamespace);
            
            foreach (ClassMemberModel memberModel in model.Members)
            {
                dtObject.Members.Add(MemberMapper.ToMember(memberModel));
            }

            return dtObject;
        }
    }
}
