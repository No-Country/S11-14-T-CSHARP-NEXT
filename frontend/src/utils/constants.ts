export const MENU_ICONS = {
  DASHBOARD: 'dashboard',
  RESERVATIONS: 'reservations',
  STAFF: 'staff',
  STATISTICS: 'statistics',
  ROOMS: 'rooms',
  SETTINGS: 'settings',
  INCIDENT: 'incident',
  MESSAGE: 'message',
  EXIT: 'exit',
};

export const DASHBOARD_ICONS = {
  ROOMS: 'rooms',
  RESERVATIONS: 'reservations',
  STAFF: 'staff',
  INCIDENTS: 'incident',
  ROOM_AVAILABLE: 'roomAvailable',
  ROOM_OCUPIED: 'roomOcupied',
  PENDING: 'pending',
  NEW_MESSAGE: 'message',
};

export const MENU_ROUTES = [
  {
    name: 'Dashboard',
    icon: MENU_ICONS.DASHBOARD,
    path: '/',
  },
  {
    name: 'Reservas',
    icon: MENU_ICONS.RESERVATIONS,
    path: '/about',
  },
  {
    name: 'Staff',
    icon: MENU_ICONS.STAFF,
    path: '/contact',
  },
  {
    name: 'Estadísticas',
    icon: MENU_ICONS.STATISTICS,
    path: '/contact',
  },
  {
    name: 'Habitaciones',
    icon: MENU_ICONS.ROOMS,
    path: '/contact',
  },
  {
    name: 'Configuración',
    icon: MENU_ICONS.SETTINGS,
    path: '/contact',
  },
  {
    name: 'Incidentes',
    icon: MENU_ICONS.INCIDENT,
    path: '/contact',
  },
  {
    name: 'Mensajes',
    icon: MENU_ICONS.MESSAGE,
    path: '/contact',
  },
  ,
  {
    name: 'Salir',
    icon: MENU_ICONS.EXIT,
    path: '',
  },
];

export const DASHBOARD_INFO = [
  {
    icon: DASHBOARD_ICONS.ROOMS,
    number: '220',
    title: 'Total Habitaciones',
    className: 'text-gray-wiz',
  },
  {
    icon: DASHBOARD_ICONS.RESERVATIONS,
    number: '52',
    title: 'Reservas',
    className: 'text-gray-wiz',
  },
  {
    icon: DASHBOARD_ICONS.STAFF,
    number: '32',
    title: 'Staff',
    className: 'text-gray-wiz',
  },
  {
    icon: DASHBOARD_ICONS.INCIDENTS,
    number: '5',
    title: 'Incidentes/Quejas',
    className: 'text-gray-wiz',
  },
  {
    icon: DASHBOARD_ICONS.ROOM_AVAILABLE,
    number: '130',
    title: 'Habitaciones Disponibles',
    className: 'text-green-wiz-1',
  },
  {
    icon: DASHBOARD_ICONS.ROOM_OCUPIED,
    number: '72',
    title: 'Habitaciones Ocupadas',
    className: 'text-red-wiz-1',
  },
  {
    icon: DASHBOARD_ICONS.PENDING,
    number: '42',
    title: 'CheckIn Pendientes',
    className: 'text-gray-wiz',
  },
  {
    icon: DASHBOARD_ICONS.NEW_MESSAGE,
    number: '5',
    title: 'Mensajes Nuevos',
    className: 'text-gray-wiz',
  },
];
