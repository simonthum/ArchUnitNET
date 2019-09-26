﻿using System;
using System.Collections.Generic;
using ArchUnitNET.Domain;
using ArchUnitNET.Fluent.Syntax.Elements.Types.Classes;

namespace ArchUnitNET.Fluent.Syntax.Elements
{
    public interface IObjectsShould<TRuleTypeShouldConjunction, TRuleType>
        where TRuleType : ICanBeAnalyzed
        where TRuleTypeShouldConjunction : SyntaxElement<TRuleType>
    {
        TRuleTypeShouldConjunction Exist();
        TRuleTypeShouldConjunction Be(ICanBeAnalyzed firstObject, params ICanBeAnalyzed[] moreObjects);
        TRuleTypeShouldConjunction DependOn(string pattern);
        TRuleTypeShouldConjunction OnlyDependOn(IType firstType, params IType[] moreTypes);
        TRuleTypeShouldConjunction OnlyDependOn(Type firstType, params Type[] moreTypes);
        TRuleTypeShouldConjunction OnlyDependOn(IObjectProvider<IType> types);
        TRuleTypeShouldConjunction OnlyDependOn(IEnumerable<IType> types);
        TRuleTypeShouldConjunction HaveName(string name);
        TRuleTypeShouldConjunction HaveFullName(string fullname);
        TRuleTypeShouldConjunction HaveNameStartingWith(string pattern);
        TRuleTypeShouldConjunction HaveNameEndingWith(string pattern);
        TRuleTypeShouldConjunction HaveNameContaining(string pattern);
        TRuleTypeShouldConjunction BePrivate();
        TRuleTypeShouldConjunction BePublic();
        TRuleTypeShouldConjunction BeProtected();
        TRuleTypeShouldConjunction BeInternal();
        TRuleTypeShouldConjunction BeProtectedInternal();
        TRuleTypeShouldConjunction BePrivateProtected();
        ClassesShouldThat<TRuleTypeShouldConjunction, TRuleType> DependOnClassesThat();
        ClassesShouldThat<TRuleTypeShouldConjunction, TRuleType> OnlyDependOnClassesThat();


        //Negations

        TRuleTypeShouldConjunction NotExist();
        TRuleTypeShouldConjunction NotBe(ICanBeAnalyzed firstObject, params ICanBeAnalyzed[] moreObjects);
        TRuleTypeShouldConjunction NotDependOn(string pattern);
        TRuleTypeShouldConjunction NotDependOn(IType firstType, params IType[] moreTypes);
        TRuleTypeShouldConjunction NotDependOn(Type firstType, params Type[] moreTypes);
        TRuleTypeShouldConjunction NotDependOn(IObjectProvider<IType> types);
        TRuleTypeShouldConjunction NotDependOn(IEnumerable<IType> types);
        TRuleTypeShouldConjunction NotHaveName(string name);
        TRuleTypeShouldConjunction NotHaveFullName(string fullname);
        TRuleTypeShouldConjunction NotHaveNameStartingWith(string pattern);
        TRuleTypeShouldConjunction NotHaveNameEndingWith(string pattern);
        TRuleTypeShouldConjunction NotHaveNameContaining(string pattern);
        TRuleTypeShouldConjunction NotBePrivate();
        TRuleTypeShouldConjunction NotBePublic();
        TRuleTypeShouldConjunction NotBeProtected();
        TRuleTypeShouldConjunction NotBeInternal();
        TRuleTypeShouldConjunction NotBeProtectedInternal();
        TRuleTypeShouldConjunction NotBePrivateProtected();
        ClassesShouldThat<TRuleTypeShouldConjunction, TRuleType> NotDependOnClassesThat();
    }
}