﻿using System;
using System.Data.Entity;

namespace Run00.SqlCopySqlServer.IntegrationTest.Artifacts
{
	public class SourceContextInitializer : DropCreateDatabaseAlways<SourceContext>
	{
		protected override void Seed(SourceContext context)
		{
			var sampleOneChildOne = new SampleChild() { Id = Guid.Parse("E3F0C906-6FC5-4ACC-9208-21EDA6DD77C8"), Value = "ChildSampleOne", OwnerId = Guid.Parse("{63BDDD01-D781-4064-83DE-18A3DDAAF178}") };
			var sampleOneChildTwo = new SampleChild() { Id = Guid.Parse("574D0DDB-6F7D-4286-B9FD-4C56334A7038"), Value = "ChildSampleTwo", OwnerId = Guid.Parse("{CC52BE36-1EA0-4F4C-A506-C9ED399B8561}") };
			var sampleOne = new Sample()
			{
				Id = Guid.Parse("D30B9685-2C30-4395-ADED-481061397AF1"),
				Value = "SampleOne",
				OwnerId = Guid.Parse("{63BDDD01-D781-4064-83DE-18A3DDAAF178}"),
				Children = new[] { sampleOneChildOne, sampleOneChildTwo }
			};
			context.Samples.Add(sampleOne);

			var sampleTwoChildOne = new SampleChild() { Id = Guid.Parse("{57691FEA-FDC2-482A-956D-F80DA1F65E85}"), Value = "ChildSampleOne", OwnerId = Guid.Parse("{CC52BE36-1EA0-4F4C-A506-C9ED399B8561}") };
			var sampleTwoChildTwo = new SampleChild() { Id = Guid.Parse("{D3D1C39E-5142-483C-8117-801382F036DE}"), Value = "ChildSampleTwo", OwnerId = Guid.Parse("{CC52BE36-1EA0-4F4C-A506-C9ED399B8561}") };
			var sampleTwo = new Sample()
			{
				Id = Guid.Parse("2C039ED6-F402-4203-B8A5-6D3B8D3F24F6"),
				Value = "SampleTwo",
				OwnerId = Guid.Parse("{63BDDD01-D781-4064-83DE-18A3DDAAF178}"),
				Children = new[] { sampleTwoChildOne, sampleTwoChildTwo }
			};
			context.Samples.Add(sampleTwo);
		}
	}
}