# 🛠️ Dexter Servicio Técnico - Sistema Web de Gestión y Consultas

Sistema web desarrollado como proyecto técnico profesional para **Dexter Servicio Técnico**, un taller multimarca especializado en la reparación de televisores, notebooks, consolas de videojuegos y celulares ubicado en Alejandro Korn, Buenos Aires.

## 🚀 Tecnologías Utilizadas
* **Framework:** Blazor Server (.NET / C#)
* **Diseño Frontend:** Bootstrap 5 (Enfoque Mobile-First / Responsive)
* **Estilos e Iconos:** CSS Isolation y Bootstrap Icons
* **Persistencia de Datos:** Entity Framework Core con base de datos relacional
* **Control de Versiones:** Git y GitHub.

## ✨ Funcionalidades Principales
* **Página de Inicio (Home):** Presentación del taller con enlaces directos a redes sociales (WhatsApp, Instagram, Facebook), sección de especialidades, preguntas frecuentes (FAQ), horarios de atención y mapa de ubicación interactivo.
* **Secciones de Servicios Específicos:** Páginas dedicadas (`/servicios/tv`, `/servicios/notebooks`, `/servicios/consolas`, `/servicios/celulares`) con galerías fotográficas optimizadas y canales de contacto directo.
* **Formulario de Consulta Dinámico:** Permite a los clientes ingresar sus datos, modelo de equipo y tipo de falla, con validaciones en tiempo real (por ejemplo, restricción de números en el campo de nombre y apellido) y persistencia directa en base de datos.
* **Integración con WhatsApp:** Generación automática de mensajes personalizados con los datos cargados por el cliente para agilizar la presupuestación.
* **Geolocalización:** Integración de mapas embebidos y botones de "Cómo llegar" vinculados a Google Maps.
