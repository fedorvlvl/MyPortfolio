// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:Puppet2D/BlackAndWhite,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:1,rntp:1,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:0,x:34330,y:31979,varname:node_0,prsc:2|olwid-255-OUT,olcol-3495-RGB;n:type:ShaderForge.SFN_LightAttenuation,id:37,x:33662,y:32106,varname:node_37,prsc:2;n:type:ShaderForge.SFN_Dot,id:40,x:32721,y:32330,varname:node_40,prsc:2,dt:1|A-42-OUT,B-41-OUT;n:type:ShaderForge.SFN_NormalVector,id:41,x:32512,y:32424,prsc:2,pt:True;n:type:ShaderForge.SFN_LightVector,id:42,x:32512,y:32303,varname:node_42,prsc:2;n:type:ShaderForge.SFN_Dot,id:52,x:32721,y:32503,varname:node_52,prsc:2,dt:1|A-41-OUT,B-62-OUT;n:type:ShaderForge.SFN_Add,id:55,x:33662,y:32368,varname:node_55,prsc:2|A-84-OUT,B-187-RGB,C-265-OUT;n:type:ShaderForge.SFN_Power,id:58,x:32923,y:32603,cmnt:Specular Light,varname:node_58,prsc:2|VAL-52-OUT,EXP-244-OUT;n:type:ShaderForge.SFN_HalfVector,id:62,x:32512,y:32563,varname:node_62,prsc:2;n:type:ShaderForge.SFN_LightColor,id:63,x:33662,y:32235,varname:node_63,prsc:2;n:type:ShaderForge.SFN_Multiply,id:64,x:33846,y:32235,varname:node_64,prsc:2|A-37-OUT,B-63-RGB,C-55-OUT;n:type:ShaderForge.SFN_Color,id:80,x:33158,y:32258,ptovrint:False,ptlb:Color,ptin:_Color,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.6544118,c2:0.8426978,c3:1,c4:1;n:type:ShaderForge.SFN_Tex2d,id:82,x:33158,y:32082,ptovrint:False,ptlb:Diffuse,ptin:_Diffuse,varname:_Diffuse,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8993b617f08498f43adcbd90697f1c5d,ntxv:0,isnm:False|UVIN-272-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:83,x:33778,y:31848,ptovrint:False,ptlb:Normals,ptin:_Normals,varname:_Normals,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:c6dfb00dbee6bc044a8a3bb22e56e064,ntxv:3,isnm:True|UVIN-272-UVOUT;n:type:ShaderForge.SFN_Multiply,id:84,x:33363,y:32240,cmnt:Diffuse Light,varname:node_84,prsc:2|A-82-RGB,B-80-RGB,C-264-OUT;n:type:ShaderForge.SFN_AmbientLight,id:187,x:33363,y:32360,varname:node_187,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:216,x:32923,y:32503,ptovrint:False,ptlb:Bands,ptin:_Bands,varname:_Bands,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:8;n:type:ShaderForge.SFN_Slider,id:239,x:31774,y:32671,ptovrint:False,ptlb:Gloss,ptin:_Gloss,varname:_Gloss,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4511278,max:1;n:type:ShaderForge.SFN_Add,id:240,x:32512,y:32720,varname:node_240,prsc:2|A-242-OUT,B-241-OUT;n:type:ShaderForge.SFN_Vector1,id:241,x:32344,y:32808,varname:node_241,prsc:2,v1:1;n:type:ShaderForge.SFN_Multiply,id:242,x:32344,y:32658,varname:node_242,prsc:2|A-239-OUT,B-243-OUT;n:type:ShaderForge.SFN_Vector1,id:243,x:31931,y:32741,varname:node_243,prsc:2,v1:10;n:type:ShaderForge.SFN_Exp,id:244,x:32683,y:32720,varname:node_244,prsc:2,et:1|IN-240-OUT;n:type:ShaderForge.SFN_Vector1,id:255,x:34025,y:32307,varname:node_255,prsc:2,v1:0.05;n:type:ShaderForge.SFN_Posterize,id:264,x:33158,y:32424,varname:node_264,prsc:2|IN-40-OUT,STPS-216-OUT;n:type:ShaderForge.SFN_Posterize,id:265,x:33158,y:32555,varname:node_265,prsc:2|IN-58-OUT,STPS-216-OUT;n:type:ShaderForge.SFN_TexCoord,id:272,x:32633,y:32014,varname:node_272,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Tex2d,id:4634,x:33949,y:32008,ptovrint:False,ptlb:node_4634,ptin:_node_4634,varname:_node_4634,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:39634a431b46ccd40a9522779a9c0ba7,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Color,id:3495,x:33964,y:32438,ptovrint:False,ptlb:node_3495,ptin:_node_3495,varname:node_3495,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0,c2:0,c3:0,c4:1;proporder:80-82-83-216-239-4634-3495;pass:END;sub:END;*/

Shader "Shader Forge/Examples/Custom Lighting1" {
    Properties {
        _Color ("Color", Color) = (0.6544118,0.8426978,1,1)
        _Diffuse ("Diffuse", 2D) = "white" {}
        _Normals ("Normals", 2D) = "bump" {}
        _Bands ("Bands", Float ) = 8
        _Gloss ("Gloss", Range(0, 1)) = 0.4511278
        _node_4634 ("node_4634", 2D) = "white" {}
        _node_3495 ("node_3495", Color) = (0,0,0,1)
    }
    SubShader {
        Tags {
            "RenderType"="Opaque"
        }
        Pass {
            Name "Outline"
            Tags {
            }
            Cull Front
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform float4 _node_3495;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( float4(v.vertex.xyz + v.normal*0.05,1) );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                return fixed4(_node_3495.rgb,0);
            }
            ENDCG
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            struct VertexInput {
                float4 vertex : POSITION;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.pos = UnityObjectToClipPos( v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
                float3 finalColor = 0;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
    }
    FallBack "Puppet2D/BlackAndWhite"
    CustomEditor "ShaderForgeMaterialInspector"
}
