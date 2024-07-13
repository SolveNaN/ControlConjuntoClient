﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConjuntoClient.Shared
{
    public class Documento
    {
        public int Id { get; set; }
        public string Nombre { get; set; }=string.Empty;
        public string Descripcion { get; set; }=string.Empty;
        public UploadResult? UploadResult { get; set; }
        public int UploadResultId { get; set; }
    }
}
