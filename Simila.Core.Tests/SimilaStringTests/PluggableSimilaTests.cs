﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simila.Core.Levenstein;

namespace Simila.Core.Tests.SimilaStringTests
{
    [TestClass]
    public class PluggableSimilaTests
    {
        //[TestMethod]
        //public void Simila_ShouldWork_WithOverridingConfigs()
        //{
        //    var simila = new Simila();

        //    Assert.IsTrue(simila.AreSimilar("Cat", "Kat"));

        //    // Overriding Word similarity resolver method.
        //    simila.Resolver.RegisterType<ISimilarityResolver<Word>, MistakeBasedSimilarityResolver<Word>>();

        //    Assert.IsFalse(simila.AreSimilar("Cat", "Kat"));
        //    Assert.IsTrue(simila.AreSimilar("color", "colour"));
        //}

        //[TestMethod]
        //public void Simila_ShouldWork_WithOverridingIntroducingMistakes()
        //{
        //    var simila = new Simila();

        //    Assert.IsFalse(simila.AreSimilar("War", "Fight"));

        //    var mistakeRepository = new DefaultMistakeRepository<Word>();
        //    mistakeRepository.AddMistake("War", "Fight", .9f);

        //    // Overriding Word similarity resolver method.
        //    simila.Resolver.RegisterInstance<IMistakeRepository<Word>>(mistakeRepository);

        //    Assert.IsTrue(simila.AreSimilar("Cat", "Kat"));

        //    Assert.IsTrue(simila.AreSimilar("color", "colour"));
        //}
    }
}
