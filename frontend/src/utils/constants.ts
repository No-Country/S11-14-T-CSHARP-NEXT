export const MENU_ICONS = {
    DASHBOARD:"dashboard",
    RESERVATIONS:"reservations",
    STAFF:"staff",
    STATISTICS:"statistics",
    ROOMS:"rooms",
    SETTINGS:"settings",
    INCIDENT:"incident",
    MESSAGE:"message",
    EXIT:"exit"
}

export const MENU_ROUTES = [
    {
        name: 'Dashboard',
        icon: MENU_ICONS.DASHBOARD,
        path: '/'
    },
    {
        name: 'Reservas',
        icon: MENU_ICONS.RESERVATIONS,
        path: '/about'
    },
    {
        name: 'Staff',
        icon: MENU_ICONS.STAFF,
        path: '/contact'
    },
    {
        name: 'Estadísticas',
        icon: MENU_ICONS.STATISTICS,
        path: '/contact'
    },
    {
        name: 'Habitaciones',
        icon: MENU_ICONS.ROOMS,
        path: '/contact'
    },
    {
        name: 'Configuración',
        icon: MENU_ICONS.SETTINGS,
        path: '/contact'
    },
    {
        name: 'Incidentes',
        icon: MENU_ICONS.INCIDENT,
        path: '/contact'
    },
    {
        name: 'Mensajes',
        icon: MENU_ICONS.MESSAGE,
        path: '/contact'
    },
    ,
    {
        name: 'Salir',
        icon: MENU_ICONS.EXIT,
        path: ''
    }
]

