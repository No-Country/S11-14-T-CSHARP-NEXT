import { FaBell } from 'react-icons/fa'

const Notification: React.FC = () => {
  return (
    <div className='bg-white p-3 rounded-md mx-2 cursor-pointer'>
        <FaBell
          color='#86858D'
        />
    </div>
  )
}

export default Notification