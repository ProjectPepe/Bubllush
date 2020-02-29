Shader "Custom/Shape"{
	Properties{
		_MainTex("Albedo (RGB)", 2D) = "white" {}
	}
		SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
		#pragma surface surf Lambert vertex:vert

		// Use shader model 3.0 target, to get nicer looking lighting
		#pragma target 3.0

		sampler2D _MainTex;

		struct Input
		{
			float2 uv_MainTex;
		};

		void vert(inout appdata_full v,out Input o)
		{
			UNITY_INITIALIZE_OUTPUT
		}
		ENDCG
	}
	FallBack "Diffuse"
}
