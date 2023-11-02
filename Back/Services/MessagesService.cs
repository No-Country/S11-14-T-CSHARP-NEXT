using HotelWiz.Back.Common.Dto;

namespace HotelWiz.Back.Services
{
    public class MessagesService
    {
        public List<Message> GenerateMessage()
        {

            List<Message> messages = new List<Message>();

            Random random = new Random();

            // Mensaje 1
            Message message1 = new Message
            {
                Id = 1,
                From = "cliente1@gmail.com",
                Subject = "Consulta de disponibilidad para el 12/11/2023",
                Body = "Estimado hotel,\n\nMe gustaría saber si hay disponibilidad para una habitación doble para el 12 de noviembre de 2023. ¿Podrían confirmar la reserva?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 1",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = false
            };
            messages.Add(message1);

            // Mensaje 2
            Message message2 = new Message
            {
                Id = 2,
                From = "cliente2@gmail.com",
                Subject = "Preguntas sobre las instalaciones del hotel",
                Body = "Estimado hotel,\n\nTengo algunas preguntas sobre las instalaciones del hotel. ¿Cuentan con piscina climatizada?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 2",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now,
                IsReaded = false
            };
            messages.Add(message2);


            Message message3 = new Message
            {
                Id = 3,
                From = "cliente3@gmail.com",
                Subject = "Solicitud de habitación con vista al mar",
                Body = "Estimado hotel,\n\nMe gustaría solicitar una habitación con vista al mar para mi estancia del 20 al 25 de diciembre. ¿Es posible realizar esta asignación?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 3",
                HasAttachment = false,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = true
            };
            messages.Add(message3);

            // Mensaje 4
            Message message4 = new Message
            {
                Id = 4,
                From = "cliente4@gmail.com",
                Subject = "Confirmación de reserva para el 05/01/2024",
                Body = "Estimado hotel,\n\nAgradezco la confirmación de la reserva para el 5 de enero de 2024. ¿Podrían proporcionar los detalles de mi reserva?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 4",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now,
                IsReaded = true
            };
            messages.Add(message4);

            // Mensaje 5
            Message message5 = new Message
            {
                Id = 5,
                From = "cliente5@gmail.com",
                Subject = "Consulta sobre tarifas y servicios adicionales",
                Body = "Estimado hotel,\n\nQuisiera obtener información sobre las tarifas de las habitaciones y los servicios adicionales que ofrecen. ¿Tienen servicio de transporte al aeropuerto?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 5",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = false
            };
            messages.Add(message5);

            Message message6 = new Message
            {
                Id = 6,
                From = "cliente6@gmail.com",
                Subject = "Consulta sobre servicios de spa",
                Body = "Estimado hotel,\n\nMe gustaría saber si disponen de servicios de spa y cuáles son los tratamientos disponibles. ¿Es necesario reservar con anticipación?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 6",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = false
            };
            messages.Add(message6);

            // Mensaje 7
            Message message7 = new Message
            {
                Id = 7,
                From = "cliente7@gmail.com",
                Subject = "Modificación de reserva para el 18/12/2023",
                Body = "Estimado hotel,\n\nNecesito realizar una modificación en mi reserva para el 18 de diciembre de 2023. ¿Podrían ayudarme con esto?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 7",
                HasAttachment = false,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = true
            };
            messages.Add(message7);

            // Mensaje 8
            Message message8 = new Message
            {
                Id = 8,
                From = "cliente8@gmail.com",
                Subject = "Solicitud de información sobre transporte local",
                Body = "Estimado hotel,\n\nQuisiera saber si disponen de servicio de transporte para moverme en la ciudad y cuáles son las opciones disponibles. ¿Hay algún costo adicional?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 8",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = true
            };
            messages.Add(message8);

            // Mensaje 9
            Message message9 = new Message
            {
                Id = 9,
                From = "cliente9@gmail.com",
                Subject = "Consulta sobre políticas de cancelación",
                Body = "Estimado hotel,\n\nMe gustaría conocer cuáles son las políticas de cancelación en caso de que necesite modificar o anular mi reserva. ¿Hay algún cargo asociado?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 9",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = false
            };
            messages.Add(message9);

            // Mensaje 10
            Message message10 = new Message
            {
                Id = 10,
                From = "cliente10@gmail.com",
                Subject = "Consulta sobre disponibilidad de habitaciones familiares",
                Body = "Estimado hotel,\n\nEstoy buscando una habitación familiar para mi estancia del 15 al 20 de enero de 2024. ¿Tienen disponibilidad en esas fechas?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 10",
                HasAttachment = false,
                ReceivedBy = DateTime.Now,
                IsReaded = true
            };
            messages.Add(message10);

            // Mensaje 11
            Message message11 = new Message
            {
                Id = 11,
                From = "cliente11@gmail.com",
                Subject = "Consulta sobre opciones de desayuno",
                Body = "Estimado hotel,\n\nMe gustaría saber si ofrecen opciones de desayuno y cuáles son las alternativas disponibles. ¿Hay algún costo adicional?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 11",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = false
            };
            messages.Add(message11);

            // Mensaje 12
            Message message12 = new Message
            {
                Id = 12,
                From = "cliente12@gmail.com",
                Subject = "Consulta sobre actividades en los alrededores",
                Body = "Estimado hotel,\n\nMe gustaría saber si tienen recomendaciones de actividades o lugares para visitar cerca del hotel. ¿Podrían proporcionar información al respecto?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 12",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = true
            };
            messages.Add(message12);

            // Mensaje 13
            Message message13 = new Message
            {
                Id = 13,
                From = "cliente13@gmail.com",
                Subject = "Solicitud de habitación con cama adicional",
                Body = "Estimado hotel,\n\nNecesito una habitación con una cama adicional para mi estancia del 10 al 15 de febrero de 2024. ¿Es posible organizar esto?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 13",
                HasAttachment = false,
                ReceivedBy = DateTime.Now,
                IsReaded = true
            };
            messages.Add(message13);

            // Mensaje 14
            Message message14 = new Message
            {
                Id = 14,
                From = "cliente14@gmail.com",
                Subject = "Consulta sobre políticas de mascotas",
                Body = "Estimado hotel,\n\nMe gustaría saber si permiten la estadía de mascotas y cuáles son las políticas al respecto. ¿Hay algún cargo adicional?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 14",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = false
            };
            messages.Add(message14);

            // Mensaje 15
            Message message15 = new Message
            {
                Id = 15,
                From = "cliente15@gmail.com",
                Subject = "Consulta sobre opciones de entretenimiento",
                Body = "Estimado hotel,\n\nMe gustaría saber si ofrecen opciones de entretenimiento o actividades para los huéspedes. ¿Tienen alguna programación especial?\n\nQuedo atento a su respuesta.\n\nSaludos,\nCliente 15",
                HasAttachment = random.Next(2) == 0,
                ReceivedBy = DateTime.Now.AddDays(-random.Next(1, 7)),
                IsReaded = true
            };
            messages.Add(message15);

            // Mensaje 16
            Message message16 = new Message
            {
                Id = 16,
                From = "cliente16@gmail.com",
                Subject = "Consulta sobre facilidades para personas con movilidad reducida",
                Body = "Estimado hotel,\n\nTengo un familiar con movilidad reducida y me gustaría saber si cuentan con facilidades para personas en esa condición."

            };
            messages.Add(message16);

            foreach (var msg in messages)
            {
                msg.Origin = Enum.GetName(MessageOrigins.Email);
            }
            //this.messages.ForEach(x => x.Origin = Enum.GetName(MessageOrigins.Email));

            return messages.OrderByDescending(x => x.ReceivedBy).ToList();
        }
    }
}
