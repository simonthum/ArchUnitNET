﻿using System;
using ArchUnitNET.Domain;
using ArchUnitNET.Fluent.Syntax.Elements.Types.Attributes;
using static ArchUnitNET.Fluent.Syntax.ActivatorHandler;

namespace ArchUnitNET.Fluent.Syntax.Elements.Types
{
    public class TypesShould<TRuleTypeShouldConjunction, TRuleType> :
        ObjectsShould<TRuleTypeShouldConjunction, TRuleType>,
        ITypesShould<TRuleTypeShouldConjunction, TRuleType>
        where TRuleType : IType
        where TRuleTypeShouldConjunction : SyntaxElement<TRuleType>
    {
        // ReSharper disable once MemberCanBeProtected.Global
        public TypesShould(IArchRuleCreator<TRuleType> ruleCreator) : base(ruleCreator)
        {
        }

        public TRuleTypeShouldConjunction Be(Type firstType, params Type[] moreTypes)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.Be(firstType, moreTypes));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction ImplementInterface(string pattern)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.ImplementInterface(pattern));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction ImplementInterface(Interface intf)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.ImplementInterface(intf));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction ResideInNamespace(string pattern)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.ResideInNamespace(pattern));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HavePropertyMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.HavePropertyMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HaveFieldMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.HaveFieldMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HaveMethodMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.HaveMethodMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction HaveMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.HaveMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction BeNested()
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.BeNested());
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        //Complex Conditions

        public AttributesShouldThat<TRuleTypeShouldConjunction, TRuleType> HaveAttributesThat()
        {
            _ruleCreator.BeginComplexCondition(TypesConditionDefinition<TRuleType>.HaveAttributesThat());
            return new AttributesShouldThat<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public AttributesShouldThat<TRuleTypeShouldConjunction, TRuleType> OnlyHaveAttributesThat()
        {
            _ruleCreator.BeginComplexCondition(TypesConditionDefinition<TRuleType>.OnlyHaveAttributesThat());
            return new AttributesShouldThat<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }


        //Negations


        public TRuleTypeShouldConjunction NotBe(Type firstType, params Type[] moreTypes)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotBe(firstType, moreTypes));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotImplementInterface(string pattern)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotImplementInterface(pattern));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotImplementInterface(Interface intf)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotImplementInterface(intf));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotResideInNamespace(string pattern)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotResideInNamespace(pattern));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotHavePropertyMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotHavePropertyMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotHaveFieldMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotHaveFieldMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotHaveMethodMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotHaveMethodMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotHaveMemberWithName(string name)
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotHaveMemberWithName(name));
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        public TRuleTypeShouldConjunction NotBeNested()
        {
            _ruleCreator.AddCondition(TypesConditionDefinition<TRuleType>.NotBeNested());
            return CreateSyntaxElement<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }

        //Complex Condition Negations

        public AttributesShouldThat<TRuleTypeShouldConjunction, TRuleType> NotHaveAttributesThat()
        {
            _ruleCreator.BeginComplexCondition(TypesConditionDefinition<TRuleType>.NotHaveAttributesThat());
            return new AttributesShouldThat<TRuleTypeShouldConjunction, TRuleType>(_ruleCreator);
        }
    }
}