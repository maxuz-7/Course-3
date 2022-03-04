#version 330 core
out vec4 FragColor;

in vec3 TexCoords;
in float visibility;

uniform samplerCube skybox;
float zNear = 0.1f;
float zFar = 100.0f;
float Linear(float depth){
        float z = depth * 2.0f - 1.0f;
        return (2.0f * zNear *zFar) / (zFar + zNear - z * (zFar - zNear));
}

void main(){
	float depth = Linear(gl_FragCoord.z) / zFar;
	FragColor = texture(skybox, TexCoords);// * vec4(vec3(depth), 1.0f);// * visibility + vec4(0.f)*(1 - visibility);  
	FragColor = mix(vec4(0.5f, 0.5f, 0.5f, 1.0f), FragColor, visibility);  
}
