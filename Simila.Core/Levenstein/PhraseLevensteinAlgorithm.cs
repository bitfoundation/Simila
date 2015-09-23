﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Simila.Core;
using Simila.Core.CostResolvers;
using Simila.Core.Levenstein;
using Simila.Core.Levenstein.CostResolvers;

namespace LevenshtienAlgorithm
{
    public class PhraseLevensteinAlgorithm : LevenshteinAlgorithm<Phrase, Word>,  ISimilarityAlgorithm
    {
        public PhraseLevensteinAlgorithm(): base(new WordCostResolver())
        {
        }

        public double GetSimilarity(string left, string right)
        {
            return GetSimilarity((Phrase) left, right);
        }
    }
}
