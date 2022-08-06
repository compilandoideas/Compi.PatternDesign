﻿using CompilandoIdeas.PatternDesign.Rules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilandoIdeas.PatternDesign.Rules
{
    public class RuleEngine
    {
        private readonly IEnumerable<IRule> _rules;
        public RuleEngine(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public Record Calculate(Record record)
        {

            foreach (var rule in _rules)
            {
                if (rule.ShouldRun(record)) 
                    record = rule.Evaluate(record);
            }

            return record;
        }
    }
}
