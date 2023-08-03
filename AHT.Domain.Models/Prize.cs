using AHT.Domain.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Execution;

namespace AHT.Domain.Models
{
    public class Prize : EntityBase<int>, IAggregateRoot
    {
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        public override string[] Validate()
        {
            //throw new NotImplementedException();
            var scope = new AssertionScope();

            Title.Should().NotBeNull("El titulo  no puede ser nulo");
            Title.Should().HaveLength(8);
            Description.Should().NotBeNull("La descripcion no puede estar nula");


            var exceptions = scope.Discard();

            return exceptions;

        }
    }
}
