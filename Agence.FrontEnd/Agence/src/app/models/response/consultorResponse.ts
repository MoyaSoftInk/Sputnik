import { ConsultorDTO } from '../dto/consultorDTO';

export class ConsultorResponse {
  isSucceded: boolean;
  message: string;
  statusCode: number;
  consultorDto: ConsultorDTO;
}
