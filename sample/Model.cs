﻿using System;
using System.Collections.Generic;
using AvaloniaGraphControl;

namespace AvaloniaGraphControlSample
{
  class NamedGraph : Graph
  {
    public NamedGraph(string name) { Name = name; }
    public string Name { get; private set; }
    public override string ToString() => Name;
  }

  class Model
  {
    public IEnumerable<NamedGraph> SampleGraphs => new NamedGraph[] {
      new SimpleGraph(),
      new SimpleInteractiveGraph(),
      new FamilyTree(),
      new StateMachine()
    };
  }
}
