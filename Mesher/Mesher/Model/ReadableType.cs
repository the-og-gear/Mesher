using System;

namespace Mesher.Model {

	// Represents a data type that can be read from text.
	// T = the type being read.
	// A parameter stores this + a name.
	interface ReadableType<T> {
		
		T parse(String text);
	}
}
