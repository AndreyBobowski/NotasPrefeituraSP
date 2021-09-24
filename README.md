# NotasPrefeituraSP
Lib para utilizar web service de emissão de notas de serviço de São Paulo

Referente ao site: http://notadomilhao.prefeitura.sp.gov.br/

Esta lib tem como objetivo ajudar todos aqueles que desejam consumir o WebService da nota de serviço de São Paulo.
Com ela toda comunicação será feita de forma transparente eliminando toda complexidade de SSL de mão dupla, geração de xmls, assinatura de xmls.

atualmente está em fase de desenvolvimento e contém acesso aos serviços.

- ConsultaCPF
- CancelamentoNFe
- EnvioRPS
- EnvioLoteRPS
- TesteEnvioLoteRPS

**Para usar é necessário ter um certificado ICP Brasil válido A1 ou A3**
# Como Usar
```c#
using NotasPrefeituraSP//inclua a referencia
```
Devemos criar um novo objeto do tipo **NotasPrefeituraSPClient**.

O método *GetCertificate()* e *GetCPFCNPJ()* são ficticios para levantar os dados necesários para criar o Objeto.

*X509Certificate2 Certificado* - É o Token ICP Brasil obrigatório para se autenticar com a prefeitura.

*CPFCNPJ* - Documento a qual o certificado foi emitido CPF caso eCPF ou CNPJ caso eCNPJ.
```c#
...
X509Certificate2 Certificado = GetCertificate(); // Certificado ICP Brasil A1 ou A3 necessário para autenticação pelo WebService da prefeitura
string CPFCNPJ = GetCPFCNPJ();
NotasPrefeituraSPClient client = new NotasPrefeituraSPClient(Certificado, CPFCNPJ);
...
```

Após criar o objeto basta apenas chamar seus metodos preenchendo seus parametros corretamente
```c#
var result = client.ConsultaCNPJ(60316817000103); // Consulta um CPF ou CNPJ
if(result.Cabecalho.Sucesso)
  Console.WriteLine(result.Detalhe[0].InscricaoMunicipal);
```
