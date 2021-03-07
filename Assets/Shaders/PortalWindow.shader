Shader "Custom/portal window"
{
    
    SubShader
{
    ZWrite off
    ColorMask 0

    Stencil{
       Ref 1
       pass replace

    }


     

        Pass
        {
            
        }
    }
}