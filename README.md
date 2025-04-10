# raycast por Pedro Santos e Enzo Luciano

nós utilizamos o Raycast para criar um raio que após atingir o alvo o destruiria usando a função de Destroy, e para criar e gerar constante mente o alvo, o tornamos ele em um Prefab para ser recriado com todas suas características presentes.

codigos Raycast

No Void Start colocamos para no começo a usar a função GerarTarget para criar os alvos, no Void Uptade criamos condições para caso certa tecla seja presionada lance uma certa fima de raio.
Criamos a função Lançar para criar os Rays e a função de criar uma esfera magenta caso destrua o alvo, e a função de caso o Ray acerte um objeto com Tag Target, destruir-l, e caso não manda uma mensagem de erro.
o SphereIndicator usa um switch para decidir se usa o CriarObject, o InstanciaPrefab ou o GerarTarget.
o CriarObject serve para gerar objetos de esfera pela cena.
o InstanciaPrefab manda usar o prebab de Bobm Material.
o GerarTarget instancia o prefab target e gera ele em posiçôes aleatórias na cena.

![image](https://github.com/user-attachments/assets/a293c6b9-d355-4742-a1f8-5f86be4df122)

![image](https://github.com/user-attachments/assets/5d3aefa4-96f7-4841-ab33-ee64977bb26d)

![image](https://github.com/user-attachments/assets/34ea1318-6c69-47bd-b08e-eb847d5af7ea)

![image](https://github.com/user-attachments/assets/cadd1030-b74f-4060-91f2-5f91d93bfc1c)

![image](https://github.com/user-attachments/assets/85366b54-c572-4670-a576-d50bb3e2520a)

codigos do MoveWASD

criar um codigo que permite se mover usando as setas WASD, e mutar de escala com o X e rotação com o R, e mandar uma mensagem quando clicar na tecla.

![image](https://github.com/user-attachments/assets/4f488718-e542-4ed9-b158-39b632617b34)

![image](https://github.com/user-attachments/assets/7b5128db-c4b6-4ae0-acfb-2b6d1e7e80c6)

![image](https://github.com/user-attachments/assets/24713dda-1bb2-4399-92b4-691cc2676ac3)

![image](https://github.com/user-attachments/assets/1317e316-7869-4d84-8460-8be6349025b8)

codigo move Mouse

criar um codiço que rotaciona o objeto pelo movimento do mouse, entregando a impreção que o objeto está olhando os alvos

![image](https://github.com/user-attachments/assets/a044c5a6-692e-4e99-86fc-dd202f3f6cbd)

![image](https://github.com/user-attachments/assets/67af6d9d-3278-4a6f-80bb-2bdb59b9349a)
