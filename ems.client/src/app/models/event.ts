export interface Event {
  id: number;
  name: string;
  description: string;
  categoryName: string;
  venue: string;
  price: number;
  imageUrl?: string;
  date: string;
  numberOfTickets: number;
}
