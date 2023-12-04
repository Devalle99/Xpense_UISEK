Gestor de gastos para la materia de desarrollo web de 3er semestre.

Esta API está hecha con DDD en mente. Está separada en 3 capas:

1. Dominio: Permite centrarse en la modelación del dominio sin distracciones de detalles de implementación o preocupaciones de infraestructura. Aísla la lógica de dominio, facilitando la comprensión y mantenimiento del código relacionado con las reglas de negocio. Permite cambios en la lógica de dominio sin afectar otras capas, ya que las reglas de negocio están encapsuladas.
2. Aplicación: Contiene servicios de aplicación que coordinan la ejecución de operaciones de negocio, conectando las entidades y agregados del dominio. Actúa como interfaz entre la capa de presentación y la capa de dominio, gestionando las transacciones y manipulando las operaciones de persistencia. Ofrece servicios específicos para aplicaciones cliente, organizando y simplificando la interacción con el dominio.
3. Infraestructura: Contiene la implementación concreta de servicios como repositorios, persistencia y otros detalles técnicos. Se encarga de la integración con bases de datos, servicios externos, sistemas de mensajería, etc. Incluye aspectos transversales como seguridad, registro, manejo de excepciones y otros detalles de infraestructura.
