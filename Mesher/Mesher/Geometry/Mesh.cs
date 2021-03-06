﻿using Mesher.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mesher.Geometry
{

	class Mesh
	{

		// nullable
		// when non-null, this is generated by a particular body part
		// when null, this is made up of multiple meshes
		public BodyPart Owner { get; private set; }

		public List<Face> Faces { get; private set; }

		public Mesh(BodyPart owner, List<Face> faces)
		{
			Owner = owner;
			Faces = faces;
		}

		public Mesh(List<Mesh> meshes)
		{
			Faces = new List<Face>();
			foreach (Mesh mesh in meshes)
				Faces.AddRange(mesh.Faces);
		}

		public Mesh()
		{
			Faces = new List<Face>();
		}

		public void Add(Mesh mesh)
		{
			Faces.AddRange(mesh.Faces);
		}

		public override string ToString()
		{
			return "Mesh{" + Faces + ", from " + Owner + "}";
		}
	}
}
