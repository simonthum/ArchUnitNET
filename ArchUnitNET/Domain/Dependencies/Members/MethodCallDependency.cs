/*
 * Copyright 2019 TNG Technology Consulting GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace ArchUnitNET.Domain.Dependencies.Members
{
    public class MethodCallDependency : IMemberMemberDependency
    {
        //todo: (JIRA - AUCS-46) why does this dependency have Equals/HashCode methods and the others don't?? 
        public MethodCallDependency(IMember originMember, MethodMember calledMethod)
        {
            OriginMember = originMember;
            TargetMember = calledMethod;
        }

        public IMember TargetMember { get; }
        public IMember OriginMember { get; }

        public IType Origin => OriginMember.DeclaringType;
        public IType Target => TargetMember.DeclaringType;

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((MethodCallDependency) obj);
        }

        private bool Equals(IMemberMemberDependency other)
        {
            return Equals(TargetMember, other.TargetMember) && Equals(OriginMember, other.OriginMember);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((TargetMember != null ? TargetMember.GetHashCode() : 0) * 397) ^
                       (OriginMember != null ? OriginMember.GetHashCode() : 0);
            }
        }
    }
}